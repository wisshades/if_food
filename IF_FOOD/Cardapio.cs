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
    public partial class w_cardapio : Form
    {
        public w_cardapio()
        {
            InitializeComponent();
            // Garante que o evento Load vai rodar mesmo se não estiver ligado no Designer
            this.Load += new EventHandler(w_cardapio_Load);
        }

        private void w_cardapio_Load(object sender, EventArgs e)
        {
            CarregarCardapioDinamico();
        }

        private void CarregarCardapioDinamico()
        {
            try
            {
                // Limpa qualquer cartão antigo antes de recarregar
                flowLayoutPanel1.Controls.Clear();

                using (OracleConnection conn = ConexaoOracle.ObterConexao())
                {
                    string sql = "SELECT NOME_PROD, DESC_PRODUTO, PRECO, IMAGEM FROM PRODUTO ORDER BY ID_PRODUTO";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Ainda não há produtos cadastrados no banco.", "Cardápio Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        while (reader.Read())
                        {
                            // 1. Cria o cartão principal (quadradinho igual ao seu print)
                            Panel card = new Panel();
                            card.Width = 310;
                            card.Height = 165;
                            card.BorderStyle = BorderStyle.FixedSingle;
                            card.Margin = new Padding(15);
                            card.BackColor = Color.WhiteSmoke;

                            // 2. PictureBox para a foto do produto (lado esquerdo)
                            PictureBox pb = new PictureBox();
                            pb.Width = 110;
                            pb.Height = 110;
                            pb.Top = 15;
                            pb.Left = 15;
                            pb.BorderStyle = BorderStyle.FixedSingle;
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;

                            // Lê o caminho da imagem salvo pelo OpenFileDialog no cadastro
                            string caminhoImg = reader["IMAGEM"] != DBNull.Value ? reader["IMAGEM"].ToString() : "";
                            if (!string.IsNullOrEmpty(caminhoImg) && File.Exists(caminhoImg))
                            {
                                pb.ImageLocation = caminhoImg;
                            }
                            card.Controls.Add(pb);

                            // 3. Nome do produto centralizado embaixo da foto
                            Label lblNome = new Label();
                            lblNome.Text = reader["NOME_PROD"].ToString();
                            lblNome.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                            lblNome.TextAlign = ContentAlignment.MiddleCenter;
                            lblNome.Top = 132;
                            lblNome.Left = 15;
                            lblNome.Width = 110;
                            card.Controls.Add(lblNome);

                            // 4. Descrição do produto (topo direito)
                            Label lblDesc = new Label();
                            lblDesc.Text = reader["DESC_PRODUTO"].ToString();
                            lblDesc.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                            lblDesc.Top = 15;
                            lblDesc.Left = 140;
                            lblDesc.Width = 155;
                            lblDesc.Height = 75;
                            card.Controls.Add(lblDesc);

                            // 5. Texto fixo "Preço"
                            Label lblTextoPreco = new Label();
                            lblTextoPreco.Text = "Preço";
                            lblTextoPreco.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                            lblTextoPreco.Top = 108;
                            lblTextoPreco.Left = 140;
                            lblTextoPreco.Width = 45;
                            card.Controls.Add(lblTextoPreco);

                            // 6. Caixinha branca com o valor formatado em R$
                            TextBox txtPreco = new TextBox();
                            decimal preco = Convert.ToDecimal(reader["PRECO"]);
                            txtPreco.Text = preco.ToString("C2");
                            txtPreco.ReadOnly = true;
                            txtPreco.BackColor = Color.White;
                            txtPreco.Top = 105;
                            txtPreco.Left = 190;
                            txtPreco.Width = 95;
                            card.Controls.Add(txtPreco);

                            // Adiciona o cartão pronto dentro do FlowLayoutPanel
                            flowLayoutPanel1.Controls.Add(card);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o cardápio: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Cardapio_Click(object sender, EventArgs e)
        {

        }

        private void w_cardapio_Load_1(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
