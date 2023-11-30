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
    public partial class FPrincipal : Form
    {
        Form abc;
        string userLogged = "";
        string strNivelUser = "";
        string strImgUser = "";

        public FPrincipal()
        {
            InitializeComponent();
        }

        public FPrincipal(string user, Form atual): this()
        {
            userLogged = user;
            abc = atual;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormListaProdutos formListProd = new FormListaProdutos();
            //flp.mdiparent = this;
            //flp.windowstate = formwindowstate.maximized;
            //flp.formborderstyle = formborderstyle.sizable;
            formListProd.ShowDialog();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            // carrega os indicadores
            load_qtde_prod();
            load_qtde_estoque_zero();
            load_qtde_estoque_min();
            load_qtde_estoque_total();

            // Carrega os gráficos
            load_data_chart2();

            // Carrega nome do usuário atuak logado
            lblUserLogged.Text = userLogged;


            // Pega o nivel do user atual
            getNivelUser();
            getImgUser(); 

            // Exibe o nível do usuário atual
            if (strNivelUser == "1")
            {
                lblNivelUser.Text = "Administrador";
            }
            if(strNivelUser == "2")
            {
                lblNivelUser.Text = "Comum";
            }
            if(strNivelUser == "3")
            {
                lblNivelUser.Text = "Gerente";
            }

            //
            if(strNivelUser == "1")
            {
                tsmiListUsers.Visible = true;
            }
            else
            {
                tsmiListUsers.Visible = false;
            }

            //
            pbProfile.Load(strImgUser.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            load_qtde_prod();
            load_data_chart2();
        }

        public void load_data_chart2()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            string queryContProdCat = @"SELECT * FROM cont_prod_cat";
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                da = new SqlDataAdapter(queryContProdCat, con);
                da.Fill(dt);
                chart2.DataSource = dt;
                con.Close();

                chart2.Series["ProdCat"].XValueMember = "categoria";
                chart2.Series["ProdCat"].YValueMembers = "qtde_prod";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void load_qtde_prod()
        {
            string queryQtdeProd = @"SELECT * FROM cont_prod";
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(queryQtdeProd, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblQtdeProd.Text = dr.GetValue(0).ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void load_qtde_estoque_min()
        {
            string queryQtdeProd = @"SELECT * FROM qtde_estoque_min";
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(queryQtdeProd, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblQtdeEstoqueMin.Text = dr.GetValue(0).ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void load_qtde_estoque_zero()
        {
            string queryQtdeProd = @"SELECT * FROM qtde_estoque_zero";
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(queryQtdeProd, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblQtdeEstoqueZero.Text = dr.GetValue(0).ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void load_qtde_estoque_total()
        {
            string queryQtdeProd = @"SELECT * FROM qtde_estoque_total";
            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(queryQtdeProd, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblQtdeEstoqueTotal.Text = dr.GetValue(0).ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void getNivelUser()
        {
            string query = @"SELECT * FROM vw_pesq_users WHERE Login = '" + userLogged + "'";

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    strNivelUser = dr.GetValue(3).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados \n " + erro);
                throw;
            }
        }

        public void getImgUser()
        {
            string query = @"SELECT * FROM usuarios WHERE login = '" + userLogged + "'";

            try
            {
                bancodedados banco = new bancodedados();
                SqlConnection con;
                con = banco.abrir_conexao();

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    strImgUser = dr.GetValue(5).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível carregar os dados \n " + erro);
                throw;
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormListaClientes formListCli = new FormListaClientes();
            formListCli.ShowDialog();
        }

        private void lblDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
            abc.Visible = true;           
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FormListaFornecedores formListForne = new FormListaFornecedores();
            formListForne.ShowDialog();
        }

        // Menu cadastro
        private void tsmiCadProd_Click(object sender, EventArgs e)
        {
            FCadPodutos formCadProd = new FCadPodutos();
            formCadProd.ShowDialog();
        }

        private void tsmiCadMarca_Click(object sender, EventArgs e)
        {
            FormCadMarca formCadNar = new FormCadMarca();
            formCadNar.ShowDialog();
        }

        private void tsmiCadCat_Click(object sender, EventArgs e)
        {
            FormCadCategorias formCadCat = new FormCadCategorias();
            formCadCat.ShowDialog();
        }

        private void tsmiCadUM_Click(object sender, EventArgs e)
        {
            FormCadUnidadeMedida formCadUM = new FormCadUnidadeMedida();
            formCadUM.ShowDialog();
        }

        private void tsmiCadCli_Click(object sender, EventArgs e)
        {
            FormCadClientes formCadCli = new FormCadClientes();
            formCadCli.ShowDialog();
        }

        private void tsmiCadForne_Click(object sender, EventArgs e)
        {
            FormCadFornecedor formCadForne = new FormCadFornecedor();
            formCadForne.ShowDialog();
        }

        private void tsmiCadEntrada_Click(object sender, EventArgs e)
        {
            //entrada estoque
        }

        private void tsmiCadSaida_Click(object sender, EventArgs e)
        {
            //saida estoque
        }

        private void tsmiListaProd_Click(object sender, EventArgs e)
        {
            FormListaProdutos formListProd = new FormListaProdutos();
            formListProd.ShowDialog();
        }

        private void tsmiListaMarca_Click(object sender, EventArgs e)
        {
            FormListaMarca formlistMarca = new FormListaMarca();
            formlistMarca.ShowDialog();
        }

        private void tsmiListaCat_Click(object sender, EventArgs e)
        {
            FormListaCategorias formListCat = new FormListaCategorias();
            formListCat.ShowDialog();
        }

        private void tsmiListaUM_Click(object sender, EventArgs e)
        {
            FormListaUnidadesMedida formListUM = new FormListaUnidadesMedida();
            formListUM.ShowDialog();
        }

        private void tsmiListaCli_Click(object sender, EventArgs e)
        {
            FormListaClientes formListCli = new FormListaClientes();
            formListCli.ShowDialog();
        }

        private void tsmiListaForne_Click(object sender, EventArgs e)
        {
            FormListaFornecedores formListForne = new FormListaFornecedores();
            formListForne.ShowDialog();
        }

        private void tsmiListaVendas_Click(object sender, EventArgs e)
        {
            // lista vendas
        }

        private void tsmiListaSaidas_Click(object sender, EventArgs e)
        {
            // listas compras
        }

        private void tsmiListUsers_Click(object sender, EventArgs e)
        {
            FormListaUsuarios formListUsers = new FormListaUsuarios();
            formListUsers.ShowDialog();
        }
    }
}
