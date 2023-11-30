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
    public partial class FormSelecionaCategoria : Form
    {
        private TextBox txtCateSelected;
        string selectedCat = "";

        public FormSelecionaCategoria()
        {
            InitializeComponent();
        }

        public FormSelecionaCategoria(TextBox txt): this()
        {
            txtCateSelected = txt;
        }

        private void FormSelecionaCategoria_Load(object sender, EventArgs e)
        {
            loadCategorias();
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCat = this.dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            txtCateSelected.Text = selectedCat;
            this.Close();
        }

        private void txtPesqCat_TextChanged(object sender, EventArgs e)
        {
            pesqCategoria();
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
    }
}
