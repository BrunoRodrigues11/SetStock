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
    public partial class FormEditUser : Form
    {
        private string idSelected = "";
        string caminhoImg = "";

        public FormEditUser()
        {
            InitializeComponent();
        }

        public FormEditUser(string id):this()
        {
            idSelected = id;
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            loadSelectedUser();
            loadNivelUser();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadImg();
        }

        public void loadImg()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagens jpg e png| *.jpg; *.png";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                caminhoImg = openFile.FileName;

            if (caminhoImg != "")
                pictureBox1.Load(caminhoImg);
        }

        private void loadSelectedUser()
        {
            string query = @"SELECT * FROM usuarios WHERE id_user = '" + idSelected + "'";

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNomeUsuario.Text = dr.GetValue(1).ToString();
                    txtLogin.Text = dr.GetValue(2).ToString();
                    txtSenha.Text = dr.GetValue(3).ToString();
                    cbxNivel.Text = dr.GetValue(4).ToString();

                    pictureBox1.Load(dr.GetValue(5).ToString());
                    caminhoImg = dr.GetValue(5).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados \n " + erro);
                throw;
            }
        }

        private void loadNivelUser()
        {
            string queryCategorias = @"SELECT * FROM nivel_user ORDER BY descricao";

            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                var cmd = con.CreateCommand();
                cmd.CommandText = queryCategorias;
                da = new SqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
            }
            catch (Exception erro)
            {

                throw erro;
            }

            cbxNivel.DataSource = dt;
            cbxNivel.DisplayMember = "descricao";
            cbxNivel.ValueMember = "id_nivel";
        }

        private void updateUser()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"UPDATE usuarios SET login = @login, senha = @senha, nivel = @nivel, nome = @nome, imgUser = @imgUser WHERE id_user = @id_user";
                    int selected = int.Parse(cbxNivel.SelectedValue.ToString());

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("login", SqlDbType.VarChar).Value = txtLogin.Text;
                    _cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = txtSenha.Text;
                    _cmd.Parameters.Add("nivel", SqlDbType.Int).Value = selected;
                    _cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = txtNomeUsuario.Text;
                    _cmd.Parameters.Add("imgUser", SqlDbType.VarChar).Value = caminhoImg;
                    _cmd.Parameters.Add("id_user", SqlDbType.Int).Value = int.Parse(idSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Usuário alterado com sucesso! ");

                    FormListaUsuarios formListUsers = new FormListaUsuarios();
                    this.Hide();
                    formListUsers.ShowDialog();
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
