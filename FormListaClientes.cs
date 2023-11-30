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
    public partial class FormListaClientes : Form
    {
        public string idCliSelected = "";

        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            loadClientes();
        }

        private void txtPesqCli_TextChanged(object sender, EventArgs e)
        {
            pesqCliente();
        }

        private void btnNovaCliente_Click(object sender, EventArgs e)
        {
            FormCadClientes formCadCli = new FormCadClientes();
            this.Hide();
            formCadCli.ShowDialog();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliSelected = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            FormEditCliente formEditCli = new FormEditCliente(idCliSelected);
            this.Hide();
            formEditCli.ShowDialog();
        }

        private void btnEscluirCli_Click(object sender, EventArgs e)
        {
            deleteCleinete();
        }

        private void loadClientes()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    string query = @"SELECT * FROM vw_pesq_cli";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = dt;
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

        private void pesqCliente()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    String strCli = txtPesqCli.Text;
                    string query = @"SELECT * FROM vw_pesq_cli WHERE CPF LIKE '%" + strCli + "%'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = dt;
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

        private void deleteCleinete()
        {
            idCliSelected = dgvClientes.CurrentRow.Cells[0].Value.ToString();

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"DELETE categorias WHERE id_categoria = @id_categoria";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("id_categoria", SqlDbType.Int).Value = int.Parse(idCliSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Categoria Deletada com sucesso!");
                    loadClientes();
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
