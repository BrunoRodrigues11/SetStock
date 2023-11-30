using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_estoque
{
    public partial class FormCadCategorias : Form
    {
        public FormCadCategorias()
        {
            InitializeComponent();
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            creteNewCategoria();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void creteNewCategoria()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryInsert = @"INSERT INTO categorias(descricao) VALUES (@descricao)";

                    SqlCommand _cmd = new SqlCommand(queryInsert, con);

                    _cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = txtNomeCategoria.Text;

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Categoria cadastrada com sucesso!");

                    // fechar o form atual e em seguida abrir outro
                    FormListaCategorias formListCat = new FormListaCategorias();
                    this.Hide();
                    formListCat.ShowDialog();
                }
                catch (SqlException msgE)
                {
                    MessageBox.Show("Erro ao Salvar dados do banco de dados \n" + msgE.Message);
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + erro.Message);
            }
        }
    }
}
