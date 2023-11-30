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
    public partial class FormEditCliente : Form
    {
        string caminhoImg = "";
        private string idSelected = "";

        public FormEditCliente()
        {
            InitializeComponent();
        }

        public FormEditCliente(string id):this()
        {
            idSelected = id;
        }

        private void FormEditCliente_Load(object sender, EventArgs e)
        {
            loadSelectedCliente();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            updateCliente();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadImg();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void loadSelectedCliente()
        {
            string query = @"SELECT * FROM clientes WHERE id_cliente = '" + idSelected + "'";

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNome.Text = dr.GetValue(1).ToString();
                    dtpDataNasc.Text = dr.GetValue(2).ToString();
                    txtCpf.Text = dr.GetValue(5).ToString();
                    txtRG.Text = dr.GetValue(4).ToString();   
                    txtTelefone.Text = dr.GetValue(3).ToString();
                    txtCelular.Text = dr.GetValue(8).ToString();
                    txtEmail.Text = dr.GetValue(6).ToString();

                    pictureBox1.Load(dr.GetValue(7).ToString());
                    caminhoImg = dr.GetValue(7).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados \n " + erro);
                throw;
            }
        }

        private void updateCliente()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"UPDATE clientes SET nome = @nome,data_nasc = @data_nasc, telefone = @telefone, rg = @rg, cpf = @cpf, email = @email, imgCli = @imgCli, celular = @celular WHERE id_cliente = @id_cliente";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = txtNome.Text;
                    _cmd.Parameters.Add("data_nasc", SqlDbType.VarChar).Value = dtpDataNasc.Text;
                    _cmd.Parameters.Add("telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                    _cmd.Parameters.Add("rg", SqlDbType.VarChar).Value = txtRG.Text;
                    _cmd.Parameters.Add("cpf", SqlDbType.VarChar).Value = txtCpf.Text;
                    _cmd.Parameters.Add("email", SqlDbType.VarChar).Value = txtEmail.Text;
                    _cmd.Parameters.Add("imgCli", SqlDbType.VarChar).Value = caminhoImg;
                    _cmd.Parameters.Add("celular", SqlDbType.VarChar).Value = txtCelular.Text;

                    _cmd.Parameters.Add("id_cliente", SqlDbType.Int).Value = int.Parse(idSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cliente alterado com sucesso!");

                    // fechar o form atual e em seguida abrir outro
                    FormListaClientes formListCli = new FormListaClientes();
                    this.Hide();
                    formListCli.ShowDialog();
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
