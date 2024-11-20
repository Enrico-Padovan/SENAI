using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geek_Store
{
    public partial class frmTela_Principal_on : Form
    {
        public frmTela_Principal_on()
        {
            InitializeComponent();
        }

        private void pbxSair_Click_1(object sender, EventArgs e)
        {
            var fechar = MessageBox.Show("Deseja mesmo fechar o programa?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (fechar == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pbxMaisVendidos_Click(object sender, EventArgs e)
        {
            frmMaisVendidos mais = new frmMaisVendidos();
            mais.ShowDialog();
        }

        private void pbxCarrinho_Click(object sender, EventArgs e)
        {
            frmComprar comprar = new frmComprar();
            comprar.ShowDialog();
        }

        private void pbxCadastroProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastroProduto = new frmCadastroProduto();
            cadastroProduto.ShowDialog();
        }

        private void demonstrativoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaisVendidos mais = new frmMaisVendidos();
            mais.ShowDialog();
        }

        private void cARRINHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComprar comprar = new frmComprar();
            comprar.ShowDialog();
        }

        private void cadsatroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastroProduto = new frmCadastroProduto();
            cadastroProduto.ShowDialog();
        }
    }

}
