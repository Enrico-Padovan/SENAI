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
    public partial class frmCadastro_Cliente : Form
    {
        public frmCadastro_Cliente(bool showSplash = true)
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
    }
}
