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
    public partial class FormListaFornecedores : Form
    {
        public string idForneSelected = "";

        public FormListaFornecedores()
        {
            InitializeComponent();
        }

        private void FormListaFornecedores_Load(object sender, EventArgs e)
        {
            loadFornecedores();
        }

        private void txtPesqForne_TextChanged(object sender, EventArgs e)
        {
            pesqFornecedor();
        }

        private void btnNovaMarca_Click(object sender, EventArgs e)
        {
            FormCadFornecedor formEditForne = new FormCadFornecedor();
            this.Hide();
            formEditForne.ShowDialog();
        }

        private void btnEscluirForne_Click(object sender, EventArgs e)
        {
            deleteFornecedor();
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

        private void deleteFornecedor()
        {
            idForneSelected = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"DELETE categorias WHERE id_categoria = @id_categoria";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("id_categoria", SqlDbType.Int).Value = int.Parse(idForneSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Categoria Deletada com sucesso!");
                    loadFornecedores();
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

        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idForneSelected = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
            FormEditForne formEditForne = new FormEditForne(idForneSelected);
            this.Hide();
            formEditForne.ShowDialog();
        }
    }
}
