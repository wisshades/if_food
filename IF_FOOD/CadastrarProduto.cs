
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace IF_FOOD
{
    public partial class w_CadastrarProduto : Form
    {
        Produto P;

        public w_CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string caminhoImagem = "";
            string imagemSalva = "";

            try
            {
       

                string nome = txt_nome.Text.Trim();
                string categoria = cb_categoria.Text.Trim();
                string descricao = txt_desc.Text.Trim();

                

                if (nome == "" ||
                    categoria == "" ||
                    descricao == "" ||
                    txt_preco.Text.Trim() == "" ||
                    txt_qnt.Text.Trim() == "" ||
                    string.IsNullOrWhiteSpace(pb_cad.ImageLocation))
                {
                    MessageBox.Show("Preencha todos os campos e selecione uma imagem!");
                    return;
                }

                
                if (nome.Length > 40)
                {
                    MessageBox.Show("O nome deve ter no máximo 40 caracteres!");
                    return;
                }

                if (categoria.Length > 20)
                {
                    MessageBox.Show("A categoria deve ter no máximo 20 caracteres!");
                    return;
                }

                if (descricao.Length > 200)
                {
                    MessageBox.Show("A descrição deve ter no máximo 200 caracteres!");
                    return;
                }

               
                decimal preco;

                CultureInfo cultura = txt_preco.Text.Contains(",")
                    ? new CultureInfo("pt-BR")
                    : CultureInfo.InvariantCulture;

                if (!decimal.TryParse(
                    txt_preco.Text.Trim(),
                    NumberStyles.Number,
                    cultura,
                    out preco) || preco < 0)
                {
                    MessageBox.Show("Digite um preço válido!");
                    return;
                }


                int quantidade;

                if (!int.TryParse(txt_qnt.Text.Trim(), out quantidade) ||
                    quantidade < 0)
                {
                    MessageBox.Show("Digite uma quantidade válida!");
                    return;
                }

                if (!File.Exists(pb_cad.ImageLocation))
                {
                    MessageBox.Show("A imagem selecionada não foi encontrada!");
                    return;
                }


                string pastaImagens = Path.Combine(
                    Application.StartupPath,
                    "Imagens"
                );

                Directory.CreateDirectory(pastaImagens);


                string extensao = Path.GetExtension(pb_cad.ImageLocation);

                string nomeImagem = Guid.NewGuid().ToString("N") + extensao;

                caminhoImagem = Path.Combine(
                    pastaImagens,
                    nomeImagem
                );


                File.Copy(
                    pb_cad.ImageLocation,
                    caminhoImagem,
                    true
                );

                imagemSalva = caminhoImagem;


                using (OracleConnection conn = ConexaoOracle.ObterConexao())
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    string sql = @"
                        INSERT INTO G6_PRODUTO
                        (
                            NOME_PROD,
                            CATEGORIA,
                            PRECO,
                            DESC_PRODUTO,
                            QTDE,
                            IMAGEM
                        )
                        VALUES
                        (
                            :nome,
                            :categoria,
                            :preco,
                            :descricao,
                            :quantidade,
                            :imagem
                        )";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.BindByName = true;

                        cmd.Parameters.Add(
                            "nome",
                            OracleDbType.Varchar2
                        ).Value = nome;

                        cmd.Parameters.Add(
                            "categoria",
                            OracleDbType.Varchar2
                        ).Value = categoria;

                        cmd.Parameters.Add(
                            "preco",
                            OracleDbType.Decimal
                        ).Value = preco;

                        cmd.Parameters.Add(
                            "descricao",
                            OracleDbType.Varchar2
                        ).Value = descricao;

                        cmd.Parameters.Add(
                            "quantidade",
                            OracleDbType.Int32
                        ).Value = quantidade;

                        cmd.Parameters.Add(
                            "imagem",
                            OracleDbType.Varchar2
                        ).Value = nomeImagem;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Produto cadastrado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (OracleException ex)
            {

                if (imagemSalva != "" && File.Exists(imagemSalva))
                {
                    File.Delete(imagemSalva);
                }

                MessageBox.Show(
                    "Erro no banco Oracle:\n" + ex.Message,
                    "Erro Oracle"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro:\n" + ex.Message,
                    "Erro"
                );
            }
        }

        private void w_CadastrarProduto_Load(object sender, EventArgs e)
        {
            if (this.P != null)
            {
                txt_nome.Text = this.P.nome;
                txt_desc.Text = this.P.Desc;
                txt_qnt.Text = this.P.Qtde.ToString();
                cb_categoria.Text = this.P.categoria;

                txt_preco.Text = this.P.Preco.ToString(
                    "0.00",
                    new CultureInfo("pt-BR")
                );
            }

            cb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;

            pb_cad.AllowDrop = true;

            pb_cad.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pb_cad_Click(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pb_cad.ImageLocation = ofd.FileName;
                    pb_cad.Load();
                }
            }
        }
    }
}
