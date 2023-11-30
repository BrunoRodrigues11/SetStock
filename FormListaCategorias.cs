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

namespace sistema_estoque
{
    public partial class FormListaCategorias : Form
    {
        public string idCatSelected = "";

        public FormListaCategorias()
        {
            InitializeComponent();
        }

        private void FormListaCategorias_Load(object sender, EventArgs e)
        {
            loadCategorias();
        }

        private void btnNovaCat_Click(object sender, EventArgs e)
        {
            FormCadCategorias formEditCat = new FormCadCategorias();
            this.Hide();
            formEditCat.ShowDialog();
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCatSelected = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            FormEditCategoria formEditCat = new FormEditCategoria(idCatSelected);
            this.Hide();
            formEditCat.ShowDialog();
        }

        private void txtPesqCat_TextChanged(object sender, EventArgs e)
        {
            pesqCategoria();
        }

        private void btnEscluirCat_Click(object sender, EventArgs e)
        {
            deleteCategoria();
        }

        private void loadCategorias()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    string query = @"SELECT * FROM vw_pesq_cat";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCategorias.DataSource = dt;
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

        private void pesqCategoria()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    String strCat = txtPesqCat.Text;
                    string query = @"SELECT * FROM vw_pesq_cat WHERE Descrição LIKE '%" + strCat + "%'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCategorias.DataSource = dt;
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

        private void deleteCategoria()
        {
            idCatSelected = dgvCategorias.CurrentRow.Cells[0].Value.ToString();

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"DELETE categorias WHERE id_categoria = @id_categoria";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("id_categoria", SqlDbType.Int).Value = int.Parse(idCatSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Categoria Deletada com sucesso!");
                    loadCategorias();
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

