using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.Models;
using Vendas.Controller;

namespace Vendas
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            ConProduto conProduto = new ConProduto();
            List<Produto> produtos = conProduto.listaProduto();
            dgvProduto.DataSource = produtos;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            this.ActiveControl = txtNome;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncerir_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNome.Text == "" || txtQuantidade.Text == "" || txtPreco.Text == "")
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    ConProduto conProduto = new ConProduto();
                    if (conProduto.registroRepetido(txtNome.Text) == true)
                    {
                        MessageBox.Show("Produto já existente em nossa base de dados!", "Produto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Text = string.Empty;
                        txtPreco.Text = string.Empty;
                        txtQuantidade.Text = string.Empty;
                        this.ActiveControl = txtNome;
                        return;
                    }
                    else
                    {
                        int quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
                        if(quantidade == 0)
                        {
                            MessageBox.Show("Por favor, a quantidade tem que ser maior que zero(0)", "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ActiveControl = txtQuantidade;
                            return;
                        }
                        else
                        {
                            conProduto.inserir(txtNome.Text, quantidade, txtPreco.Text);
                            MessageBox.Show("Produto inserido com sucesso", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNome.Text = string.Empty;
                            txtPreco.Text = string.Empty;
                            txtQuantidade.Text = string.Empty;
                            this.ActiveControl = txtNome;
                            List<Produto> produtos = conProduto.listaProduto();
                            dgvProduto.DataSource = produtos;
                        }
                    }
                }
            }
            catch  (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);     
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtId.Text == string.Empty)
                {
                    MessageBox.Show("Por fqavor digite um valor valido!", "localizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = txtId;
                    return;
                }
                else
                {
                    ConProduto conProduto = new ConProduto();
                    int Id = Convert.ToInt32(txtId.Text.Trim());
                    conProduto.localizar(Id);
                    txtNome.Text = conProduto.nome;
                    txtPreco.Text = Convert.ToString(conProduto.preco);
                    txtQuantidade.Text = Convert.ToString(conProduto.quantidade);
                    btnAtualizar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {   
                if(txtId.Text == string.Empty || txtNome.Text == string.Empty || txtPreco.Text == string.Empty ||txtQuantidade.Text == string.Empty)
                {
                    MessageBox.Show("Por favor preencha todos os capos!", "Campos obrigLatórios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int Id = Convert.ToInt32(txtId.Text.Trim());
                    int quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
                    ConProduto conProduto = new ConProduto();
                    conProduto.atualizar(Id, txtNome.Text, quantidade, txtPreco.Text);
                    MessageBox.Show("Produto atualizado com sucess!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    List<Produto> produto = conProduto.listaProduto();
                    dgvProduto.DataSource = produto;
                    txtId.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtPreco.Text = string.Empty;
                    txtQuantidade.Text = string.Empty;
                    this.ActiveControl = txtNome;
                    btnAtualizar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtId.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, entre com um ID válido", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = txtId;
                    return;
                }
                else
                {
                    int Id = Convert.ToInt32(txtId.Text.Trim());
                    ConProduto conProduto = new ConProduto();
                    conProduto.excluir(Id);
                    MessageBox.Show("Produto excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Produto> produto = conProduto.listaProduto();
                    dgvProduto.DataSource = produto;
                    txtId.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtPreco.Text = string.Empty;
                    txtQuantidade.Text = string.Empty;
                    this.ActiveControl = txtNome;
                    btnAtualizar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
            catch(Exception er) 
            {
                MessageBox.Show(er.Message);
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                this.dgvProduto.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtQuantidade.Text = row.Cells[2].Value.ToString();
                txtPreco.Text = row.Cells[3].Value.ToString();
            }
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
