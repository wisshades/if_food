using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_FOOD
{
    public partial class w_MenuAdm : Form
    {
        public w_MenuAdm()
        {
            InitializeComponent();
        }

        private void w_MenuAdm_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            try
            {
                using (OracleConnection conn = ConexaoOracle.ObterConexao())
                {
                    string sql = "SELECT ID_PRODUTO, NOME_PROD, CATEGORIA, PRECO, QTDE, DESC_PRODUTO, IMAGEM FROM G6_PRODUTO";

                    using (OracleDataAdapter adapter = new OracleDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            w_CadastrarProduto cadP = new w_CadastrarProduto();
            cadP.ShowDialog();

            CarregarProdutos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_Dashbord_Click(object sender, EventArgs e)
        {
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            w_cardapio cardapio = new w_cardapio();
            cardapio.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}