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
    public partial class FormCadUnidadeMedida : Form
    {
        public FormCadUnidadeMedida()
        {
            InitializeComponent();
        }

        private void btnSalvarUnidadeMedida_Click(object sender, EventArgs e)
        {
            createNewunidadeMedida();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createNewunidadeMedida()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryInsert = @"INSERT INTO unidade_medidas(descricao, sigla) VALUES (@descricao, @sigla)";

                    SqlCommand _cmd = new SqlCommand(queryInsert, con);

                    _cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = txtNomeUnidadeMedida.Text;
                    _cmd.Parameters.Add("sigla", SqlDbType.VarChar).Value = txtSigla.Text;

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Unidade de Medida cadastrada com sucesso!");

                    FormListaUnidadesMedida formListUM = new FormListaUnidadesMedida();
                    this.Hide();
                    formListUM.ShowDialog();
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
