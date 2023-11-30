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
    public partial class FormListaUsuarios : Form
    {
        public string idUserSelected = "";

        public FormListaUsuarios()
        {
            InitializeComponent();
        }

        private void FormListaUsuarios_Load(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void txtPesqUsuario_TextChanged(object sender, EventArgs e)
        {
            pesqUsers();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FormCadUsuarios formCadUser = new FormCadUsuarios();
            formCadUser.ShowDialog();
        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUserSelected = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
            FormEditUser formEditUser = new FormEditUser(idUserSelected);
            this.Hide();
            formEditUser.ShowDialog();
        }

        private void loadUsers()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    string query = @"SELECT * FROM vw_pesq_users";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuario.DataSource = dt;
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

        private void pesqUsers()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    String strUM = txtPesqUsuario.Text;
                    string query = @"SELECT * FROM vw_pesq_users WHERE Login LIKE '%" + strUM + "%'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuario.DataSource = dt;
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
