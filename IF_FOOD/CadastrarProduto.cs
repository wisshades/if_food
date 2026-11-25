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
    public partial class w_CadastrarProduto : Form
    {
        Produto P;

        public w_CadastrarProduto()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica os campos obrigatórios
                if (txt_nome.Text == "" ||
                    txt_preco.Text == "" ||
                    txt_qnt.Text == "" ||
                    cb_categoria.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    return;
                }

                // Converte os valores
                decimal preco = decimal.Parse(txt_preco.Text);
                int quantidade = int.Parse(txt_qnt.Text);

                // Recupera o caminho da imagem
                string imagem = pb_cad.ImageLocation;

                // Conecta ao banco Oracle
                using (OracleConnection conn = ConexaoOracle.ObterConexao())
                {
                    // Usando NOME_PROD conforme a nova estrutura da tabela
                    string sql = @"INSERT INTO PRODUTO
                       (NOME_PROD, CATEGORIA, PRECO, DESC_PRODUTO, QTDE, IMAGEM)
                       VALUES
                       (:nome, :categoria, :preco, :descricao, :quantidade, :imagem)";

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.BindByName = true;

                        cmd.Parameters.Add("nome", OracleDbType.Varchar2).Value = txt_nome.Text;
                        cmd.Parameters.Add("categoria", OracleDbType.Varchar2).Value = cb_categoria.Text;
                        cmd.Parameters.Add("preco", OracleDbType.Decimal).Value = preco;
                        cmd.Parameters.Add("descricao", OracleDbType.Varchar2).Value = txt_desc.Text;
                        cmd.Parameters.Add("quantidade", OracleDbType.Int32).Value = quantidade;
                        cmd.Parameters.Add("imagem", OracleDbType.Varchar2).Value =
                            string.IsNullOrEmpty(imagem) ? (object)DBNull.Value : imagem;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto cadastrado com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Erro no banco Oracle: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
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
                txt_preco.Text = this.P.Preco.ToString();
            }
            cb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            pb_cad.AllowDrop = true;
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
    }
}
