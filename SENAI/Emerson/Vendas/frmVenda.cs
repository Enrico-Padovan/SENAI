using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Vendas.Models;

namespace Vendas
{
    public partial class frmVenda : Form
    {
        // Conexão com o banco de dados SQL Server
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\Vendas\\DbVenda.mdf;Integrated Security=True");

        public frmVenda()
        {
            InitializeComponent();  // Inicializa os componentes do formulário
        }

        // Evento de clique no botão 'Fechar' - Fecha o formulário
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();  // Fecha o formulário
        }

        // Método para carregar os produtos no ComboBox
        private void CarregaCbxProduto()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();  // Fecha a conexão, se estiver aberta
                }
                string pro = "SELECT Id,nome FROM Produto ORDER BY nome";  // Consulta para pegar produtos ordenados pelo nome
                SqlCommand cmd = new SqlCommand(pro, con);
                con.Open();  // Abre a conexão com o banco de dados
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(pro, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "produto");  // Preenche o DataSet com os dados dos produtos
                cbxProduto.ValueMember = "Id";  // Define o campo 'Id' como valor do ComboBox
                cbxProduto.DisplayMember = "Nome";  // Define o campo 'Nome' para exibição no ComboBox
                cbxProduto.DataSource = ds.Tables["produto"];  // Atribui o DataTable ao ComboBox
                con.Close();  // Fecha a conexão
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);  // Exibe uma mensagem de erro, caso ocorra
            }
        }

        // Evento de carregamento do formulário
        private void frmVenda_Load(object sender, EventArgs e)
        {
            CarregaCbxProduto();  // Chama o método para carregar os produtos
            txtPreco.Enabled = false;  // Desabilita o campo de preço
            txtQuantidade.Enabled = false;  // Desabilita o campo de quantidade
            txtTotal.Enabled = false;  // Desabilita o campo de total
            btnAdicinar.Enabled = false;  // Desabilita o botão de adicionar
            btnEditar.Enabled = false;  // Desabilita o botão de editar
            btnExcluir.Enabled = false;  // Desabilita o botão de excluir
            btnVenda.Enabled = false;  // Desabilita o botão de realizar venda

            // Adiciona as colunas na DataGridView para exibir os itens da venda
            dgvVenda.Columns.Add("ID", "ID");
            dgvVenda.Columns.Add("Produto", "Produto");
            dgvVenda.Columns.Add("Quantidade", "Quantidade");
            dgvVenda.Columns.Add("Preco", "Preco");
            dgvVenda.Columns.Add("Total", "Total");
        }

        // Evento de seleção de um produto no ComboBox
        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();  // Fecha a conexão, se aberta
                }
                // Consulta o produto selecionado no ComboBox pelo Id
                SqlCommand cmd = new SqlCommand("SELECT * FROM Produto WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);  // Adiciona o parâmetro do Id do produto
                cmd.CommandType = CommandType.Text;
                con.Open();  // Abre a conexão
                SqlDataReader dr = cmd.ExecuteReader();  // Executa a consulta e lê os dados
                if (dr.Read())
                {
                    txtQuantidade.Enabled = true;  // Habilita o campo de quantidade
                    btnAdicinar.Enabled = true;  // Habilita o botão de adicionar
                    txtPreco.Text = dr["preco"].ToString();  // Preenche o campo de preço com o valor do produto
                    txtQuantidade.Focus();  // Coloca o foco no campo de quantidade
                }
                dr.Close();  // Fecha o leitor de dados
                con.Close();  // Fecha a conexão
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);  // Exibe uma mensagem de erro, caso ocorra
            }
        }

        // Evento de clique no botão 'Adicionar'
        private void btnAdicinar_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Por favor, digite a quantidade do produto!", "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantidade.Focus();
                return;  // Retorna sem fazer nada se não houver quantidade
            }
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();  // Fecha a conexão, se aberta
                }
                // Consulta a quantidade do produto no banco
                SqlCommand cmd = new SqlCommand("SELECT * FROM Produto WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);  // Adiciona o parâmetro do Id do produto
                con.Open();  // Abre a conexão
                SqlDataReader drs = cmd.ExecuteReader();  // Executa a consulta e lê os dados
                while (drs.Read())
                {
                    // Verifica se a quantidade solicitada é maior que a disponível
                    if (Convert.ToInt32(txtQuantidade.Text) > Convert.ToInt32(drs[2]))
                    {
                        MessageBox.Show("Quantidade Indiponivel! Por favor digite uma quantidade valida", "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQuantidade.Focus();
                        return;  // Retorna sem adicionar o item se a quantidade não for válida
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);  // Exibe uma mensagem de erro, caso ocorra
            }

            var repetido = false;
            // Verifica se o produto já foi adicionado à venda
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                if (Convert.ToString(cbxProduto.SelectedValue) == Convert.ToString(dr.Cells[0].Value))
                {
                    repetido = true;  // Marca como repetido se o produto já estiver na lista
                }
            }

            // Se o produto não for repetido, adiciona na lista
            if (repetido == false)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvVenda);  // Cria uma nova linha
                item.Cells[0].Value = cbxProduto.SelectedValue;
                item.Cells[1].Value = cbxProduto.Text;
                item.Cells[2].Value = txtQuantidade.Text;
                item.Cells[3].Value = txtPreco.Text;
                item.Cells[4].Value = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtPreco.Text);  // Calcula o total
                dgvVenda.Rows.Add(item);  // Adiciona a linha na DataGridView
                cbxProduto.Text = "";  // Limpa o ComboBox
                txtQuantidade.Text = string.Empty;  // Limpa o campo de quantidade
                txtPreco.Text = string.Empty;  // Limpa o campo de preço

                // Calcula o total geral da venda
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvVenda.Rows)
                    soma += Convert.ToDecimal(dr.Cells[4].Value);
                txtTotal.Text = soma.ToString();  // Atualiza o campo total
            }
            else
            {
                MessageBox.Show("Produto já cadastrado!", "Produto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // Alerta caso o produto já tenha sido adicionado
            }
            btnVenda.Enabled = true;
        }

        // Evento de clique em uma célula da DataGridView
        private void dgvVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvVenda.Rows[e.RowIndex];  // Obtém a linha clicada
            cbxProduto.Text = row.Cells[1].Value.ToString();  // Preenche o ComboBox com o nome do produto
            txtQuantidade.Text = row.Cells[2].Value.ToString();  // Preenche o campo de quantidade
            txtPreco.Text = row.Cells[3].Value.ToString();  // Preenche o campo de preço
            txtQuantidade.Select();  // Coloca o foco no campo de quantidade
            btnEditar.Enabled = true;  // Habilita o botão de editar
            btnExcluir.Enabled = true;  // Habilita o botão de excluir
        }

        // Evento de clique no botão 'Editar'
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;  // Obtém o índice da linha selecionada
            dgvVenda.Rows[linha].Cells[0].Value = cbxProduto.SelectedValue;  // Atualiza os valores na linha com os novos dados
            dgvVenda.Rows[linha].Cells[1].Value = cbxProduto.Text;
            dgvVenda.Rows[linha].Cells[2].Value = txtQuantidade.Text.Trim();
            dgvVenda.Rows[linha].Cells[3].Value = txtPreco.Text.Trim();
            dgvVenda.Rows[linha].Cells[4].Value = Convert.ToDecimal(txtPreco.Text.Trim()) * Convert.ToDecimal(txtQuantidade.Text.Trim());  // Atualiza o total
            cbxProduto.Text = string.Empty;  // Limpa o ComboBox
            txtQuantidade.Text = string.Empty;  // Limpa o campo de quantidade
            txtPreco.Text = string.Empty;  // Limpa o campo de preço

            // Recalcula o total da venda
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtTotal.Text = soma.ToString();  // Atualiza o campo de total
        }

        // Evento de clique no botão 'Excluir'
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;  // Obtém o índice da linha selecionada
            dgvVenda.Rows.Remove(dgvVenda.Rows[linha]);  // Remove a linha da DataGridView

            // Recalcula o total após exclusão
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtTotal.Text = soma.ToString();  // Atualiza o campo de total
        }

        // Evento de clique no botão 'Venda' - Realiza a venda
        private void btnVenda_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();  // Fecha a conexão, se aberta
            }
            con.Open();  // Abre a conexão
            SqlCommand cmd = new SqlCommand("InserirVenda", con);  // Chama a stored procedure para inserir a venda
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal.Text.Trim());  // Passa o total da venda como parâmetro
            cmd.Parameters.AddWithValue("data_venda", SqlDbType.Date).Value = DateTime.Now;  // Passa a data da venda como parâmetro
            cmd.ExecuteNonQuery();  // Executa a stored procedure

            // Obtém o ID da venda recém inserida
            string idVenda = "SELECT IDENT_CURRENT('Venda') AS id_venda";
            SqlCommand cmd2 = new SqlCommand(idVenda, con);
            Int32 idVenda2 = Convert.ToInt32(cmd2.ExecuteScalar());  // Obtém o ID gerado

            // Inicia um loop para percorrer todas as linhas do DataGridView (dgvVenda), onde cada linha representa um item vendido
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                // Cria um comando SQL para executar o procedimento armazenado "InserirItensVendidos" no banco de dados
                SqlCommand cmditens = new SqlCommand("InserirItensVendidos", con);
                // Define que o comando vai executar um procedimento armazenado
                cmditens.CommandType = CommandType.StoredProcedure;
                // Adiciona parâmetros ao comando SQL para inserir os dados do item vendido:
                // 1. ID da venda
                cmditens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = idVenda2;  // O ID da venda que foi gerado na inserção anterior
                // 2. ID do produto
                cmditens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);  // O ID do produto vem da célula da linha (coluna 0)
                // 3. Quantidade vendida do produto
                cmditens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);  // A quantidade é da célula da linha (coluna 2)
                // 4. Valor unitário do produto
                cmditens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);  // O valor unitário vem da célula da linha (coluna 3)
                // 5. Valor total do item (quantidade * valor unitário)
                cmditens.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);  // O total do item vem da célula da linha (coluna 4)
                // Executa o comando no banco de dados, inserindo os dados do item na tabela de itens vendidos
                cmditens.ExecuteNonQuery();
            }

            // Após a inserção de todos os itens, fecha a conexão com o banco de dados
            con.Close();
            // Limpa todas as linhas da DataGridView (dgvVenda), removendo os itens da venda após o processo
            dgvVenda.Rows.Clear();
            // Atualiza a interface da DataGridView, garantindo que a tela reflita as alterações após limpar as linhas
            dgvVenda.Refresh();
            // Limpa os campos de entrada de dados para preparar para uma nova venda ou operação
            cbxProduto.Text = string.Empty;  // Limpa o campo ComboBox de seleção de produto
            txtQuantidade.Text = string.Empty;  // Limpa o campo de quantidade
            txtPreco.Text = string.Empty;  // Limpa o campo de preço
            txtTotal.Text = string.Empty;  // Limpa o campo de total

            // Exibe uma mensagem ao usuário indicando que a venda foi realizada com sucesso
            MessageBox.Show("Venda realizada com sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}