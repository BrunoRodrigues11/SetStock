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
    public partial class FormSelecionarFornecedor : Form
    {
        private TextBox txtForneSelected;
        string selectedForne = "";

        public FormSelecionarFornecedor()
        {
            InitializeComponent();
        }

        public FormSelecionarFornecedor(TextBox txt): this()
        {
            txtForneSelected = txt;
        }
        
        private void FormSelecionarFornecedor_Load(object sender, EventArgs e)
        {
            loadFornecedores();
        }

        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedForne = this.dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtForneSelected.Text = selectedForne;
            this.Close();
        }

        private void txtPesqForne_TextChanged(object sender, EventArgs e)
        {
            pesqFornecedor();
        }

        private void loadFornecedores()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    string query = @"SELECT * FROM vw_pesq_forne";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvFornecedores.DataSource = dt;
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

        private void pesqFornecedor()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    String strForne = txtPesqForne.Text;
                    string query = @"SELECT * FROM vw_pesq_forne WHERE CNPJ LIKE '%" + strForne + "%'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvFornecedores.DataSource = dt;
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
