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
    public partial class FormEditProd : Form
    {
        private string idSelected = "";
        string caminhoImg = "";

        public FormEditProd()
        {
            InitializeComponent();
        }

        public FormEditProd(string id):this()
        {
            idSelected = id;
        }

        private void FormEditProd_Load(object sender, EventArgs e)
        {
            loadProd();
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            updateProd();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadImg();
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

        private void btnSelectCategoria_Click(object sender, EventArgs e)
        {
            FormSelecionaCategoria FselectC = new FormSelecionaCategoria(txtCategoria);
            FselectC.ShowDialog();
        }

        private void btnSelectUM_Click(object sender, EventArgs e)
        {
            FormSelecionarUnidadeMedida FselectUM = new FormSelecionarUnidadeMedida(txtUnidadeMedida);
            FselectUM.ShowDialog();
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
        
        private void loadProd()
        {
            string query = @"SELECT * FROM produtos WHERE id_produto = '" + idSelected + "'";
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNomeProd.Text = dr.GetValue(4).ToString();
                    txtMarca.Text = dr.GetValue(2).ToString();
                    txtFornecedor.Text = dr.GetValue(12).ToString();
                    txtCategoria.Text = dr.GetValue(1).ToString();
                    txtUnidadeMedida.Text = dr.GetValue(3).ToString();

                    txtLocalizacao.Text = dr.GetValue(5).ToString();
                    txtEstoqueAtual.Text = dr.GetValue(8).ToString();
                    txtEstoqueMax.Text = dr.GetValue(10).ToString();
                    txtEstoqueMin.Text = dr.GetValue(9).ToString();

                    txtPrecoV.Text = dr.GetValue(6).ToString();
                    txtPrecoC.Text = dr.GetValue(7).ToString();

                    pictureBox1.Load(dr.GetValue(11).ToString());
                    caminhoImg = dr.GetValue(11).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados \n " + erro);
                throw;
            }
        }

        private void updateProd()
        {
            string strImg = caminhoImg;

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                try
                {
                    string queryUpdate = @"UPDATE produtos SET id_categoria_fk = @id_categoria_fk, id_marca_fk = @id_marca_fk, id_unidade_medida_fk = @id_unidade_medida_fk, descricao = @descricao, localizacao = @localizacao, preco_venda = @preco_venda, preco_custo = @preco_custo, estoque_atual = @estoque_atual, estoque_min = @estoque_min, estoque_max = @estoque_max, imagemProd = @imagemProd, id_fornecedor_fk = @id_fornecedor_fk WHERE id_produto = @id_produto";

                    SqlCommand _cmd = new SqlCommand(queryUpdate, con);

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

                    _cmd.Parameters.Add("imagemProd", SqlDbType.VarChar).Value = caminhoImg;
                    _cmd.Parameters.Add("id_fornecedor_fk", SqlDbType.Int).Value = int.Parse(txtFornecedor.Text);

                    _cmd.Parameters.Add("id_produto", SqlDbType.Int).Value = int.Parse(idSelected);

                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Produto alterado com sucesso!");

                    // fechar o form atual e em seguida abrir outro
                    FormListaProdutos formListProd = new FormListaProdutos();
                    this.Hide();
                    formListProd.ShowDialog();
                }
                catch (SqlException msgE)
                {
                    MessageBox.Show("Erro ao alterar dados do banco de dados \n" + msgE.Message);
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + erro.Message);
            }
        }

    }
}
