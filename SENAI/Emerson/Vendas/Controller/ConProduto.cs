﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Models; // using nome_do_programa.pasta
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Vendas.Controller
{
    
    internal class ConProduto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\Vendas\\DbVenda.mdf;Integrated Security=True");
        Produto produto = new Produto();

        public List<Produto> listaProduto()
        {
            List<Produto> li = new List<Produto>();
            string sql = "SELECT * FROM Produto";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produto produto = new Produto();
                produto.Id = (int)dr["Id"];
                produto.nome = dr["nome"].ToString();
                produto.quantidade = (int)dr["quantidade"];
                produto.preco = (decimal)dr["preco"];
                li.Add(produto);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void inserir(string nome, int quantidade, string preco)
        {
            try
            {
                decimal precoFinal = Convert.ToDecimal(preco.Replace(",",",")) / 100; // Converte preco para decimal
                string sql = $"INSERT INTO Produto (nome, quantidade, preco) VALUES ('{nome}', '{quantidade}', @preco)"; // @preco: alias => apelido
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = precoFinal; // Determina o valor do alias 
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public void atualizar(int Id, string nome, int quantidade, string preco)
        {
            try
            {
                decimal precoFinal = Convert.ToDecimal(preco) / 100;
                string sql = $"UPDATE Produto SET nome = '{nome}', quantidade = '{quantidade}', preco = @preco WHERE Id = '{Id}'";
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = precoFinal; // Determina o valor do alias 
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public void excluir(int Id)
        {
            try
            {
                string sql = $"DELETE FROM Produto WHERE Id = '{Id}'";
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public void localizar(int Id)
        {
            string sql = $"SELECT * FROM Produto WHERE Id = '{Id}'";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                quantidade = (int)dr["quantidade"];
                preco = (decimal)dr["preco"];
            }
            dr.Close();
            con.Close();
        }

        public bool registroRepetido(string nome)
        {
            string sql = $"SELECT * FROM Produto WHERE nome = '{nome}'";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return /*(int)result > 0*/ true;
            }
            con.Close();
            return false;
        }
    }
}
