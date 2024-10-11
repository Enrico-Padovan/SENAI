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

namespace Vendas
{
    public partial class frmVenda : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Vendas\\DbVenda.mdf;Integrated Security=True");

        public frmVenda()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaCbxProduto()
        {
            try
            {
                if(con.State == ConnectionState.Open) 
                { 
                    con.Close();
                }
                string pro = "SELECT Id,nome FROM Produto ORDER BY nome";
                SqlCommand cmd = new SqlCommand(pro, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(pro, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "produto");
                cbxProduto.ValueMember = "Id";
                cbxProduto.DisplayMember = "Nome";
                cbxProduto.DataSource = ds.Tables["produto"];
                con.Close();
            }
            catch(Exception er) 
            {
                MessageBox.Show(er.Message);
            }
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            CarregaCbxProduto();
            txtPreco.Enabled= false;
            txtQuantidade.Enabled = false;
            txtTotal.Enabled = false;
            btnAdicinar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnVenda.Enabled = false;
        }
    }
}
