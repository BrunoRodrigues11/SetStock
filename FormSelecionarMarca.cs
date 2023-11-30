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
    public partial class FormSelecionarMarca : Form
    {
        private TextBox txtMarcaSelected;
        string selectedMarca = "";

        public FormSelecionarMarca()
        {
            InitializeComponent();
        }

        public FormSelecionarMarca(TextBox txt): this()
        {
            txtMarcaSelected = txt;
        }
        private void FormSelecionarMarca_Load(object sender, EventArgs e)
        {
            loadMarcas();
        }

        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMarca = this.dgvMarcas.CurrentRow.Cells[0].Value.ToString();
            txtMarcaSelected.Text = selectedMarca;
            this.Close();
        }

        private void txtPesqMarca_TextChanged(object sender, EventArgs e)
        {
            pesqMarca();
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

    }
}
