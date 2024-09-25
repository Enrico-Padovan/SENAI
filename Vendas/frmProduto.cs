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
    }
}
