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
    public partial class w_Det_Produto : Form
    {
        Produto Prod;

        /*public w_Det_Produto()
        {
            InitializeComponent();
        }*/
        public w_Det_Produto(Produto P)
        {
            this.Prod = P;
            InitializeComponent();
        }


        private void w_Det_Produto_Load(object sender, EventArgs e)
        {
            tb_Codigo.Text = this.Prod.Codigo;
            tb_Descricao.Text = this.Prod.Desc;
            
            tb_Preco.Text = this.Prod.Preco.ToString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {           
            
            try
            {
                ProdutoBD ProdBD = new ProdutoBD();
                this.Prod.Desc = tb_Descricao.Text;
                
                this.Prod.Preco = Double.Parse(tb_Preco.Text);

                if (this.Prod.Id_Produto == 0)
                    ProdBD.Inserir(this.Prod);
                else
                    ProdBD.Atualizar(this.Prod);

                MessageBox.Show("Produto gravado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Erro no banco Oracle ({ex.Number}): {ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
