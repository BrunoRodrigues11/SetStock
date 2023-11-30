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
    public partial class FormEditCategoria : Form
    {
        private string idSelected = "";

        public FormEditCategoria()
        {
            InitializeComponent();
        }

        public FormEditCategoria(string id):this()
        {
            idSelected = id;
        }

        private void FormEditCategoria_Load(object sender, EventArgs e)
        {
            loadSelectedCategoria();
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            updateCategoria();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadSelectedCategoria()
        {
            string query = @"SELECT * FROM categorias WHERE id_categoria = '" + idSelected + "'";

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNomeCategoria.Text = dr.GetValue(1).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados \n " + erro);
                throw;
            }
        }

        private void updateCategoria()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"UPDATE categorias SET descricao = @descricao WHERE id_categoria = @id_categoria";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = txtNomeCategoria.Text;
                    _cmd.Parameters.Add("id_categoria", SqlDbType.Int).Value = int.Parse(idSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Categoria alterada com sucesso!");

                    // fechar o form atual e em seguida abrir outro
                    FormListaCategorias formListCat = new FormListaCategorias();
                    this.Hide();
                    formListCat.ShowDialog();

                }
                catch (SqlException msgE)
                {
                    MessageBox.Show("Erro ao alterar dados do banco de dados \n" + msgE.Message);
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + erro.Message);
            }
        }
    }
}
