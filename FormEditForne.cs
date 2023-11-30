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
    public partial class FormEditForne : Form
    {
        string caminhoImg = "";
        private string idSelected = "";

        public FormEditForne()
        {
            InitializeComponent();
        }

        public FormEditForne(string id):this()
        {
            idSelected = id;
        }

        private void FormEditForne_Load(object sender, EventArgs e)
        {
            loadSelectedFornecedor();
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            updateFornecedor();
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

        private void loadSelectedFornecedor()
        {
            string query = @"SELECT * FROM fornecedores WHERE id_fornecedor = '" + idSelected + "'";

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNomeFantasia.Text = dr.GetValue(6).ToString();
                    txtRazao.Text = dr.GetValue(1).ToString();
                    txtCnpj.Text = dr.GetValue(4).ToString();
                    txtIE.Text = dr.GetValue(5).ToString();
                    txtTelefone.Text = dr.GetValue(2).ToString();
                    txtCelular.Text = dr.GetValue(8).ToString();
                    txtEmail.Text = dr.GetValue(3).ToString();

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

        private void updateFornecedor()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"UPDATE fornecedores SET razao_social = @razao_social,telefone = @telefone, email = @email, cnpj = @cnpj, ie = @ie, nome_fantasia = @nome_fantasia, imgForne = @imgForne, celular = @celular WHERE id_fornecedor = @id_fornecedor";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

                    _cmd.Parameters.Add("razao_social", SqlDbType.VarChar).Value = txtRazao.Text;
                    _cmd.Parameters.Add("telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                    _cmd.Parameters.Add("email", SqlDbType.VarChar).Value = txtEmail.Text;
                    _cmd.Parameters.Add("cnpj", SqlDbType.VarChar).Value = txtCnpj.Text;
                    _cmd.Parameters.Add("ie", SqlDbType.VarChar).Value = txtIE.Text;
                    _cmd.Parameters.Add("nome_fantasia", SqlDbType.VarChar).Value = txtNomeFantasia.Text;
                    _cmd.Parameters.Add("imgForne", SqlDbType.VarChar).Value = caminhoImg;
                    _cmd.Parameters.Add("celular", SqlDbType.VarChar).Value = txtCelular.Text;

                    _cmd.Parameters.Add("id_fornecedor", SqlDbType.Int).Value = int.Parse(idSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Fornecedor alterado com sucesso!");

                    // fechar o form atual e em seguida abrir outro
                    FormListaFornecedores formListForne = new FormListaFornecedores();
                    this.Hide();
                    formListForne.ShowDialog();
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
