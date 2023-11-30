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
    public partial class FormListaProdutos : Form
    {
        public string idProdSelected =  "";

        public FormListaProdutos()
        {
            InitializeComponent();
        }

        private void FormListaProdutos_Load(object sender, EventArgs e)
        {
            loadProd();
        }

        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            FCadPodutos fcp = new FCadPodutos();
            this.Hide();
            fcp.ShowDialog();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idProdSelected = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            FormEditProd fep = new FormEditProd(idProdSelected);
            this.Hide();
            fep.ShowDialog();
        }

        private void txtPesqProd_TextChanged(object sender, EventArgs e)
        {
            pesqProd();
        }

        private void btnEscluirProd_Click(object sender, EventArgs e)
        {
            deletaProd();
        }

        private void loadProd()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    string query = @"SELECT * FROM lista_prod";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProdutos.DataSource = dt;
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

        private void pesqProd()
        {
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();
                try
                {
                    String strProd = txtPesqProd.Text;
                    string query = @"SELECT * FROM lista_prod WHERE Produto LIKE '%" + strProd + "%'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProdutos.DataSource = dt;
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

        private void deletaProd()
        {
            string idProd = dgvProdutos.CurrentRow.Cells[0].Value.ToString(); ;
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                DialogResult result = MessageBox.Show("Você realmente deseja excluir este produto?", "Excluir produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string queryDelete = @"DELETE produtos WHERE id_produto = @id_produto";

                        SqlCommand _cmd = new SqlCommand(queryDelete, con);

                        _cmd.Parameters.Add("id_produto", SqlDbType.Int).Value = int.Parse(idProd);

                        _cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Produto excluido com sucesso!");
                        this.Close();
                    }
                    catch (SqlException msgE)
                    {
                        MessageBox.Show("Erro ao excluir dados do banco de dados \n" + msgE.Message);
                    }
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + erro.Message);
            }
        }
    }
}
