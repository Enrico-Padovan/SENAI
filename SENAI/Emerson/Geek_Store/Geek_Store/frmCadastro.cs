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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt)

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
