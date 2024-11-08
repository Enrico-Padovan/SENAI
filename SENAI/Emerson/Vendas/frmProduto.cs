using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.Models;  // Referência aos modelos de dados (provavelmente para a classe Produto)
using Vendas.Controller;  // Referência ao controlador de produtos

namespace Vendas
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();  // Inicializa os componentes do formulário
        }

        // Evento de carregamento do formulário
        private void frmProduto_Load(object sender, EventArgs e)
        {
            // Cria uma instância do controlador de produtos (ConProduto)
            ConProduto conProduto = new ConProduto();
            // Obtém a lista de produtos e atribui à DataGridView para exibição
            List<Produto> produtos = conProduto.listaProduto();
            dgvProduto.DataSource = produtos;
            // Desabilita os botões de atualizar e excluir ao carregar o formulário
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            // Define o foco no campo de texto 'txtNome'
            this.ActiveControl = txtNome;
        }

        // Evento de clique no botão 'Fechar' - Fecha o formulário
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();  // Fecha o formulário
        }

        // Evento de clique no botão 'Inserir' - Insere um novo produto
        private void btnIncerir_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se todos os campos obrigatórios foram preenchidos
                if (txtNome.Text == "" || txtQuantidade.Text == "" || txtPreco.Text == "")
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;  // Retorna sem fazer nada se os campos estiverem vazios
                }
                else
                {
                    ConProduto conProduto = new ConProduto();
                    // Verifica se o produto já existe no banco de dados
                    if (conProduto.registroRepetido(txtNome.Text) == true)
                    {
                        MessageBox.Show("Produto já existente em nossa base de dados!", "Produto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpa os campos e foca novamente no campo 'txtNome'
                        txtNome.Text = string.Empty;
                        txtPreco.Text = string.Empty;
                        txtQuantidade.Text = string.Empty;
                        this.ActiveControl = txtNome;
                        return;
                    }
                    else
                    {
                        // Converte a quantidade do produto para inteiro
                        int quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
                        // Verifica se a quantidade é maior que zero
                        if (quantidade == 0)
                        {
                            MessageBox.Show("Por favor, a quantidade tem que ser maior que zero(0)", "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ActiveControl = txtQuantidade;  // Foca no campo de quantidade
                            return;
                        }
                        else
                        {
                            // Insere o produto no banco de dados
                            conProduto.inserir(txtNome.Text, quantidade, txtPreco.Text);
                            MessageBox.Show("Produto inserido com sucesso", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // Limpa os campos e atualiza a lista de produtos
                            txtNome.Text = string.Empty;
                            txtPreco.Text = string.Empty;
                            txtQuantidade.Text = string.Empty;
                            this.ActiveControl = txtNome;
                            List<Produto> produtos = conProduto.listaProduto();
                            dgvProduto.DataSource = produtos;  // Atualiza a DataGridView com a lista de produtos
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Exibe erro se ocorrer uma exceção
            }
        }

        // Evento de clique na imagem (para localizar produto por ID)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o campo de ID não está vazio
                if (txtId.Text == string.Empty)
                {
                    MessageBox.Show("Por favor digite um valor válido!", "Localizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = txtId;  // Foca no campo de ID
                    return;
                }
                else
                {
                    ConProduto conProduto = new ConProduto();
                    // Converte o ID digitado para inteiro
                    int Id = Convert.ToInt32(txtId.Text.Trim());
                    // Chama o método de localização do produto no banco de dados
                    conProduto.localizar(Id);
                    // Preenche os campos com as informações do produto encontrado
                    txtNome.Text = conProduto.nome;
                    txtPreco.Text = Convert.ToString(conProduto.preco);
                    txtQuantidade.Text = Convert.ToString(conProduto.quantidade);
                    // Habilita os botões de atualizar e excluir
                    btnAtualizar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);  // Exibe erro se ocorrer uma exceção
            }
        }

        // Evento de clique no botão 'Atualizar' - Atualiza os dados do produto
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se os campos obrigatórios estão preenchidos
                if (txtId.Text == string.Empty || txtNome.Text == string.Empty || txtPreco.Text == string.Empty || txtQuantidade.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Retorna sem fazer nada se os campos estiverem vazios
                }
                else
                {
                    // Converte os valores de entrada para os tipos corretos
                    int Id = Convert.ToInt32(txtId.Text.Trim());
                    int quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());

                    // Cria uma instância do controlador de produtos
                    ConProduto conProduto = new ConProduto();
                    // Chama o método para atualizar as informações do produto
                    conProduto.atualizar(Id, txtNome.Text, quantidade, txtPreco.Text);
                    MessageBox.Show("Produto atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza a lista de produtos na DataGridView
                    List<Produto> produto = conProduto.listaProduto();
                    dgvProduto.DataSource = produto;
                    // Limpa os campos após a atualização
                    txtId.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtPreco.Text = string.Empty;
                    txtQuantidade.Text = string.Empty;
                    this.ActiveControl = txtNome;
                    // Desabilita os botões de atualizar e excluir
                    btnAtualizar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);  // Exibe erro se ocorrer uma exceção
            }
        }

        // Evento de clique no botão 'Excluir' - Exclui o produto
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o campo de ID está preenchido
                if (txtId.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, entre com um ID válido", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = txtId;  // Foca no campo de ID
                    return;
                }
                else
                {
                    // Converte o ID para inteiro
                    int Id = Convert.ToInt32(txtId.Text.Trim());
                    ConProduto conProduto = new ConProduto();
                    // Chama o método de exclusão do produto
                    conProduto.excluir(Id);
                    MessageBox.Show("Produto excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza a lista de produtos na DataGridView
                    List<Produto> produto = conProduto.listaProduto();
                    dgvProduto.DataSource = produto;
                    // Limpa os campos após a exclusão
                    txtId.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtPreco.Text = string.Empty;
                    txtQuantidade.Text = string.Empty;
                    this.ActiveControl = txtNome;
                    // Desabilita os botões de atualizar e excluir
                    btnAtualizar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);  // Exibe erro se ocorrer uma exceção
            }
        }

        // Evento de clique em uma célula da DataGridView
        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha clicada
                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                // Marca a linha como selecionada
                this.dgvProduto.Rows[e.RowIndex].Selected = true;
                // Preenche os campos com os dados do produto selecionado
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtQuantidade.Text = row.Cells[2].Value.ToString();
                txtPreco.Text = row.Cells[3].Value.ToString();
            }
            // Habilita os botões de atualizar e excluir
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}