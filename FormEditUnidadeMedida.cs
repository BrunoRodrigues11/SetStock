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
    public partial class FormEditUnidadeMedida : Form
    {
        private string idSelected = "";

        public FormEditUnidadeMedida()
        {
            InitializeComponent();
        }

        public FormEditUnidadeMedida(string id): this()
        {
            idSelected = id;
        }

        private void FormEditUnidadeMedida_Load(object sender, EventArgs e)
        {
            loadSelectedUM();
        }

        private void btnSalvarUnidadeMedida_Click(object sender, EventArgs e)
        {
            updateUM();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadSelectedUM()
        {
            string query = @"SELECT * FROM unidade_medidas WHERE id_unidade_medida = '" + idSelected + "'";

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNomeUnidadeMedida.Text = dr.GetValue(1).ToString();
                    txtSigla.Text = dr.GetValue(2).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados \n " + erro);
                throw;
            }
        }

        private void updateUM()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"UPDATE unidade_medidas SET descricao = @descricao, sigla = @sigla WHERE id_unidade_medida = @id_unidade_medida";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = txtNomeUnidadeMedida.Text;
                    _cmd.Parameters.Add("sigla", SqlDbType.VarChar).Value = txtSigla.Text;
                    _cmd.Parameters.Add("id_unidade_medida", SqlDbType.Int).Value = int.Parse(idSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Unidade medida alterada com sucesso!");

                    // fechar o form atual e em seguida abrir outro
                    FormListaUnidadesMedida formListUM = new FormListaUnidadesMedida();
                    this.Hide();
                    formListUM.ShowDialog();

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
