
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace IF_FOOD
{
    public partial class w_cardapio : Form
    {
        public w_cardapio()
        {
            InitializeComponent();

            this.Load -= w_cardapio_Load;
            this.Load += w_cardapio_Load;
        }

        private void w_cardapio_Load(object sender, EventArgs e)
        {
            CarregarCardapioDinamico();
        }

        private void CarregarCardapioDinamico()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.AutoScroll = true;

                using (OracleConnection conn = ConexaoOracle.ObterConexao())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    string sql = @"
                        SELECT
                            ID_PRODUTO,
                            NOME_PROD,
                            DESC_PRODUTO,
                            PRECO,
                            IMAGEM
                        FROM G6_PRODUTO
                        ORDER BY ID_PRODUTO";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show(
                                    "Ainda não há produtos cadastrados no banco.",
                                    "Cardápio vazio",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                return;
                            }

                            while (reader.Read())
                            {
                                Panel card = new Panel();

                                card.Width = 310;
                                card.Height = 165;
                                card.BorderStyle = BorderStyle.FixedSingle;
                                card.Margin = new Padding(15);
                                card.BackColor = Color.WhiteSmoke;

                                PictureBox pb = new PictureBox();

                                pb.Width = 110;
                                pb.Height = 110;
                                pb.Top = 15;
                                pb.Left = 15;
                                pb.BorderStyle = BorderStyle.FixedSingle;
                                pb.SizeMode = PictureBoxSizeMode.Zoom;

                                string nomeImagem = reader["IMAGEM"] != DBNull.Value
                                    ? reader["IMAGEM"].ToString()
                                    : "";

                                if (!string.IsNullOrWhiteSpace(nomeImagem))
                                {
                                    string caminhoImg;

                                    if (Path.IsPathRooted(nomeImagem))
                                    {
                                        caminhoImg = nomeImagem;
                                    }
                                    else
                                    {
                                        caminhoImg = Path.Combine(
                                            Application.StartupPath,
                                            "Imagens",
                                            Path.GetFileName(nomeImagem)
                                        );
                                    }

                                    if (File.Exists(caminhoImg))
                                    {
                                        try
                                        {
                                            pb.ImageLocation = caminhoImg;
                                            pb.Load();
                                        }
                                        catch
                                        {
                                            pb.Image = null;
                                        }
                                    }
                                }

                                card.Controls.Add(pb);

                                Label lblNome = new Label();

                                lblNome.Text = reader["NOME_PROD"].ToString();
                                lblNome.Font = new Font(
                                    "Segoe UI",
                                    9,
                                    FontStyle.Bold
                                );
                                lblNome.TextAlign = ContentAlignment.MiddleCenter;
                                lblNome.Top = 132;
                                lblNome.Left = 15;
                                lblNome.Width = 110;
                                lblNome.Height = 25;

                                card.Controls.Add(lblNome);

                                Label lblDesc = new Label();

                                lblDesc.Text = reader["DESC_PRODUTO"].ToString();
                                lblDesc.Font = new Font(
                                    "Segoe UI",
                                    9,
                                    FontStyle.Regular
                                );
                                lblDesc.Top = 15;
                                lblDesc.Left = 140;
                                lblDesc.Width = 155;
                                lblDesc.Height = 75;

                                card.Controls.Add(lblDesc);

                                Label lblTextoPreco = new Label();

                                lblTextoPreco.Text = "Preço:";
                                lblTextoPreco.Font = new Font(
                                    "Segoe UI",
                                    9,
                                    FontStyle.Regular
                                );
                                lblTextoPreco.Top = 108;
                                lblTextoPreco.Left = 140;
                                lblTextoPreco.Width = 45;

                                card.Controls.Add(lblTextoPreco);

                                TextBox txtPreco = new TextBox();

                                decimal preco = Convert.ToDecimal(
                                    reader["PRECO"]
                                );

                                txtPreco.Text = preco.ToString(
                                    "C2",
                                    new CultureInfo("pt-BR")
                                );

                                txtPreco.ReadOnly = true;
                                txtPreco.BackColor = Color.White;
                                txtPreco.Top = 105;
                                txtPreco.Left = 190;
                                txtPreco.Width = 95;

                                card.Controls.Add(txtPreco);

                                flowLayoutPanel1.Controls.Add(card);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar o cardápio:\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
