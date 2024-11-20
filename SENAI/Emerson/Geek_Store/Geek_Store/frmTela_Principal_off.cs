using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geek_Store
{
    public partial class frmTela_Principal_off : Form
    {
        public frmTela_Principal_off(bool showSplash = true)
        {
            InitializeComponent();

            if (showSplash)
            {
                frmSplash splash = new frmSplash();
                splash.Show();
                Application.DoEvents();
                Thread.Sleep(3000);
                splash.Close();
            }
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            var fechar = MessageBox.Show("Deseja mesmo fechar o programa?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (fechar == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pbxMaisVendidos_Click(object sender, EventArgs e)
        {
            frmMaisVendidos MaisVendidos = new frmMaisVendidos();
            MaisVendidos.Show();
        }

        private void demonstrativoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaisVendidos MaisVendidos = new frmMaisVendidos();
            MaisVendidos.Show();
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTela_Principal_on logar = new frmTela_Principal_on();
            logar.Show();
        }

        private void cadatroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
        }
    }
}
