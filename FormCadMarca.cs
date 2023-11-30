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
    public partial class FormCadMarca : Form
    {
        public FormCadMarca()
        {
            InitializeComponent();
        }

        private void btnSalvarMarca_Click(object sender, EventArgs e)
        {
            createNewMarca();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createNewMarca()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryInsert = @"INSERT INTO marcas(descricao) VALUES (@descricao)";

                    SqlCommand _cmd = new SqlCommand(queryInsert, con);

                    _cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = txtNomeMarca.Text;

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Marca cadastrada com sucesso!");

                    FormListaMarca formListMarca = new FormListaMarca();
                    this.Hide();
                    formListMarca.Show();
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
