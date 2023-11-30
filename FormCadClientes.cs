using Correios;
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
    public partial class FormCadClientes : Form
    {
        string caminhoImg = "";
        private String entryIdStr;

        public FormCadClientes()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            createNewCliente();
        }

        private void txtConsultaCep_Click(object sender, EventArgs e)
        {
            consultarCep();
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

        private void consultarCep()
        {
            if (string.IsNullOrEmpty(txtCep.Text))
            {
                MessageBox.Show("O campo CEP esta vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    CorreiosApi correiosapi = new CorreiosApi();
                    var retorno = correiosapi.consultaCEP(txtCep.Text);

                    if (retorno == null)
                    {
                        MessageBox.Show("O CEP informado é inválido. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        txtEndereco.Text = retorno.end;
                        txtBairro.Text = retorno.bairro;
                        txtCidade.Text = retorno.cidade;
                        txtUf.Text = retorno.uf;
                        MessageBox.Show("Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possivel consultar o CEP informado\n " + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int getEntryID()
        {
            string queryInsertLast = @"select coalesce( max(id_cliente), 0) AS abc from clientes";

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection conn;
                conn = banco.abrir_conexao();

                SqlCommand command = new SqlCommand(queryInsertLast, conn);

                entryIdStr = command.ExecuteScalar().ToString();
                conn.Close();
                return int.Parse(entryIdStr);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return -1;
            }
        }

        private void createNewCliente()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryInsert = @"INSERT INTO clientes(nome,data_nasc,telefone,rg,cpf,email,imgCli,celular) VALUES (@nome, @data_nasc, @telefone, @rg, @cpf, @email, @imgCli, @celular)";

                    SqlCommand _cmd = new SqlCommand(queryInsert, con);

                    _cmd.Parameters.Add("nome", SqlDbType.VarChar).Value = txtNome.Text;
                    _cmd.Parameters.Add("data_nasc", SqlDbType.VarChar).Value = dtpDataNasc.Text;
                    _cmd.Parameters.Add("telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                    _cmd.Parameters.Add("rg", SqlDbType.VarChar).Value = txtRG.Text;
                    _cmd.Parameters.Add("cpf", SqlDbType.VarChar).Value = txtCpf.Text;
                    _cmd.Parameters.Add("email", SqlDbType.VarChar).Value = txtEmail.Text;

                    if (caminhoImg == "")
                    {
                        _cmd.Parameters.Add("imgCli", SqlDbType.VarChar).Value = "C:/sistema_estoque/img/fornecedor-avatar.png";
                    }
                    else
                    {
                        _cmd.Parameters.Add("imgCli", SqlDbType.VarChar).Value = caminhoImg;
                    }

                    _cmd.Parameters.Add("celular", SqlDbType.VarChar).Value = txtCelular.Text;

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    txtNumero.Text = "" + getEntryID();

                    createNewEnderecoCli();

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

        private void createNewEnderecoCli()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryInsert = @"INSERT INTO enderecos_cliente(id_cliente_fk,cep,endereco,complemento,bairro,cidade,uf,numero) VALUES (@id_cliente_fk, @cep, @endereco, @complemento, @bairro, @cidade, @uf, @numero)";

                    SqlCommand _cmd = new SqlCommand(queryInsert, con);

                    _cmd.Parameters.Add("id_cliente_fk", SqlDbType.Int).Value = int.Parse(txtNumero.Text);
                    _cmd.Parameters.Add("cep", SqlDbType.VarChar).Value = txtCep.Text;
                    _cmd.Parameters.Add("endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
                    _cmd.Parameters.Add("complemento", SqlDbType.VarChar).Value = txtComplemento.Text;
                    _cmd.Parameters.Add("bairro", SqlDbType.VarChar).Value = txtBairro.Text;
                    _cmd.Parameters.Add("cidade", SqlDbType.VarChar).Value = txtCidade.Text;
                    _cmd.Parameters.Add("uf", SqlDbType.VarChar).Value = txtUf.Text;
                    _cmd.Parameters.Add("numero", SqlDbType.VarChar).Value = txtNumeroE.Text;

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Endereço cadastrado com sucesso!");
                    //txtNumero.Text = "" + getEntryID();

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
