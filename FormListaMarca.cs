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
    public partial class FormListaMarca : Form
    {
        public string idMarcaSelected = "";

        public FormListaMarca()
        {
            InitializeComponent();
        }

        private void FormListaMarca_Load(object sender, EventArgs e)
        {
            loadMarcas();
        }

        private void txtPesqForne_TextChanged(object sender, EventArgs e)
        {
            pesqMarca();
        }

        private void btnNovoForne_Click(object sender, EventArgs e)
        {
            FormCadMarca formCadMarca = new FormCadMarca();
            this.Hide();
            formCadMarca.ShowDialog();
        }

        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idMarcaSelected = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
            FormEditMarca formEditMarca = new FormEditMarca(idMarcaSelected);
            this.Hide();
            formEditMarca.ShowDialog();
        }

        private void btnExcluirMarca_Click(object sender, EventArgs e)
        {
            deleteMarca();
        }

        private void loadMarcas()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    string query = @"SELECT * FROM vw_pesq_marca";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMarcas.DataSource = dt;
                    con.Close();
                }
                catch (SqlException msgE)
                {
                    MessageBox.Show("Erro ao carregar dados do banco de dados \n" + msgE.Message);
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + erro.Message);
            }
        }

        private void pesqMarca()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    String strMarca = txtPesqMarca.Text;
                    string query = @"SELECT * FROM vw_pesq_marca WHERE Descrição LIKE '%" + strMarca + "%'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMarcas.DataSource = dt;
                    con.Close();
                }
                catch (SqlException msgE)
                {
                    MessageBox.Show("Erro ao carregar dados do banco de dados \n" + msgE.Message);
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + erro.Message);
            }
        }

        private void deleteMarca()
        {
            idMarcaSelected = dgvMarcas.CurrentRow.Cells[0].Value.ToString();

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"DELETE marcas WHERE id_marca = @id_marca";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("id_marca", SqlDbType.Int).Value = int.Parse(idMarcaSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Marca Deletada com sucesso!");
                    loadMarcas();
                }
                catch (SqlException msgE)
                {
                    MessageBox.Show("Erro ao deletar dados do banco de dados \n" + msgE.Message);
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + erro.Message);
            }
        }
    }
}
