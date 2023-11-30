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
    public partial class FormEditMarca : Form
    {
        private string idSelected = "";

        public FormEditMarca()
        {
            InitializeComponent();
        }

        public FormEditMarca(string id): this()
        {
            idSelected = id;
        }

        private void FormEditMarca_Load(object sender, EventArgs e)
        {
            loadSelectedMarca();
        }

        private void btnSalvarMarca_Click(object sender, EventArgs e)
        {
            updateMarca();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadSelectedMarca()
        {
            string query = @"SELECT * FROM marcas WHERE id_marca = '" + idSelected + "'";

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNomeMarca.Text = dr.GetValue(1).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados \n " + erro);
                throw;
            }
        }

        private void updateMarca()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"UPDATE marcas SET descricao = @descricao WHERE id_marca = @id_marca";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = txtNomeMarca.Text;
                    _cmd.Parameters.Add("id_marca", SqlDbType.Int).Value = int.Parse(idSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Marca alterada com sucesso!");

                    // fechar o form atual e em seguida abrir outro
                    FormListaMarca formListMarca = new FormListaMarca();
                    this.Hide();
                    formListMarca.ShowDialog();

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
