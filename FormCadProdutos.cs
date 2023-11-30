using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sistema_estoque
{
    public partial class FCadPodutos : Form
    {
        string caminhoImg = "";
        public FCadPodutos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            createNewProduto();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como preencher o campo localização \n ex: B2C5N4 \n\n onde: \n \n B = Bloco \n C = Corredor \n N = Nível \n Apenas o bloco é obrigatório. ", "Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadImg();
        }
        private void btnSelectCategoria_Click(object sender, EventArgs e)
        {
            FormSelecionaCategoria FselectC = new FormSelecionaCategoria(txtCategoria);
            FselectC.ShowDialog();
        }

        private void btnSelectMarca_Click(object sender, EventArgs e)
        {
            FormSelecionarMarca FselectM = new FormSelecionarMarca(txtMarca);
            FselectM.ShowDialog();
        }

        private void btnSelectForne_Click(object sender, EventArgs e)
        {
            FormSelecionarFornecedor FselectF = new FormSelecionarFornecedor(txtFornecedor);
            FselectF.ShowDialog();
        }

        private void btnSelectUM_Click(object sender, EventArgs e)
        {
            FormSelecionarUnidadeMedida FselectUM = new FormSelecionarUnidadeMedida(txtUnidadeMedida);
            FselectUM.ShowDialog();
        }

        // Método para Carregar Imagem
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

        private void createNewProduto()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryInsert = @"INSERT INTO produtos(id_categoria_fk, id_marca_fk, id_unidade_medida_fk, descricao, localizacao, preco_venda, preco_custo, estoque_atual, estoque_min, estoque_max, imagemProd, id_fornecedor_fk) VALUES (@id_categoria_fk, @id_marca_fk, @id_unidade_medida_fk, @descricao, @localizacao, @preco_venda, @preco_custo, @estoque_atual, @estoque_min, @estoque_max, @imagemProd, @id_fornecedor_fk)";

                    SqlCommand _cmd = new SqlCommand(queryInsert, con);

                    _cmd.Parameters.Add("id_categoria_fk", SqlDbType.Int).Value = int.Parse(txtCategoria.Text);
                    _cmd.Parameters.Add("id_marca_fk", SqlDbType.Int).Value = int.Parse(txtMarca.Text);
                    _cmd.Parameters.Add("id_unidade_medida_fk", SqlDbType.Int).Value = int.Parse(txtUnidadeMedida.Text);

                    _cmd.Parameters.Add("descricao", SqlDbType.VarChar).Value = txtNomeProd.Text;
                    _cmd.Parameters.Add("localizacao", SqlDbType.VarChar).Value = txtLocalizacao.Text;
                    _cmd.Parameters.Add("preco_venda", SqlDbType.Decimal).Value = Decimal.Parse(txtPrecoV.Text);
                    _cmd.Parameters.Add("preco_custo", SqlDbType.Decimal).Value = Decimal.Parse(txtPrecoC.Text);

                    _cmd.Parameters.Add("estoque_atual", SqlDbType.Int).Value = int.Parse(txtEstoqueAtual.Text);
                    _cmd.Parameters.Add("estoque_min", SqlDbType.Int).Value = int.Parse(txtEstoqueMin.Text);
                    _cmd.Parameters.Add("estoque_max", SqlDbType.Int).Value = int.Parse(txtEstoqueMax.Text);

                    if (caminhoImg == "")
                    {
                        _cmd.Parameters.Add("imagemProd", SqlDbType.VarChar).Value = "C:/sistema_estoque/img/fundo-sem-imagem.png";
                    }
                    else
                    {
                        _cmd.Parameters.Add("imagemProd", SqlDbType.VarChar).Value = caminhoImg;
                    }

                    _cmd.Parameters.Add("id_fornecedor_fk", SqlDbType.Int).Value = int.Parse(txtFornecedor.Text);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Produto cadastrado com sucesso!");

                    FormListaProdutos formListaProd = new FormListaProdutos();
                    this.Hide();
                    formListaProd.Show();
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

        public DataTable dql(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                var cmd = con.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
