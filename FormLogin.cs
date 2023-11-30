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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            validateLogin();
        }

        private void cbxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMostrarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void validateLogin()
        {
            string strUser = txtLogin.Text;
            string strPswd = txtSenha.Text;

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    string queryValidateLogin = @"SELECT * FROM usuarios WHERE login = '"+ strUser +"' AND senha = '"+ strPswd +"'";

                    SqlDataAdapter da = new SqlDataAdapter(queryValidateLogin, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if(dt.Rows.Count == 1)
                    {
                        FPrincipal fp = new FPrincipal(strUser,this);
                        this.Hide();
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Select();
                        fp.Show();
                        MessageBox.Show("Bem-Vindo(a) ao SetStock!", "Bem-Vindor", MessageBoxButtons.OK);

                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha Incorreta", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Select();
                    }
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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
