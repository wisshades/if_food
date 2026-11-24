using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_FOOD
{
    public partial class w_Lista_Produtos : Form
    {                
        public w_Lista_Produtos()
        {
            InitializeComponent();            
        }              

        private void w_Lista_Produtos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Produto P = new Produto();
            w_Det_Produto w_Det = new w_Det_Produto(P);
            w_Det.ShowDialog();

            /*if (P.Desc != "") //Cadastrou!!!
            {
                //this.l_Prod.Add(P); 
                //Grava o objeto na BD
            }*/
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {            
            try
            {
                List<Produto> L_Prod = new List<Produto>();
                List<string> L_ProdImp = new List<string>();
                ProdutoBD ProdBD = new ProdutoBD();

                L_Prod = ProdBD.ListarTodos();

                foreach (Produto P in L_Prod)
                {
                    L_ProdImp.Add("Cód: " + P.Codigo + " Descr.:" + P.Desc + " Qtde.:" + P.Qtde + " Preço: " + P.Preco);
                }

                w_Imp_Lista w_Imp = new w_Imp_Lista(L_ProdImp, "Produtos");
                w_Imp.ShowDialog();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Não foi possível carregar os produtos do Oracle ({ex.Number}):\n{ex.Message}",
                                "Erro de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao listar produtos:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            

    }
}
