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
    public partial class FormCadUsuarios : Form
    {
        string caminhoImg = "";

        public FormCadUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            createNewUser(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadImg();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNivelUser();
        }

        private void FormCadUsuarios_Load(object sender, EventArgs e)
        {
            loadNivelUser();
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
                
        private void createNewUser()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryInsert = @"INSERT INTO usuarios(login, senha, nivel, nome, imgUser) VALUES (@login, @senha, @nivel, @nome, @imgUser)";
                    int selected = int.Parse(cbxNivel.SelectedValue.ToString());

                    SqlCommand _cmd = new SqlCommand(queryInsert, con);

                    _cmd.Parameters.Add("login", SqlDbType.VarChar).Value = txtLogin.Text;
                    _cmd.Parameters.Add("senha", SqlDbType.VarChar).Value = txtSenha.Text;
                    _cmd.Parameters.Add("nivel", SqlDbType.Int).Value = selected;
                    _cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = txtNomeUsuario.Text;

                    if (caminhoImg == "")
                    {
                        _cmd.Parameters.Add("imgUser", SqlDbType.VarChar).Value = "C:/sistema_estoque/img/fornecedor-avatar.png";
                    }
                    else
                    {
                        _cmd.Parameters.Add("imgUser", SqlDbType.VarChar).Value = caminhoImg;
                    }

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Usuário cadastrado com sucesso!\n " + cbxNivel.SelectedItem.ToString());

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
