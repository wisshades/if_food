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
    public partial class w_Lista_Pedidos : Form
    {
        /*List<Produto> l_Prod;
        List<Pedido> l_Ped;*/

        /*public w_Lista_Pedidos(List<Produto> l_Produtos, List<Pedido> l_Pedidos) : this()
        {
            this.l_Prod = l_Produtos;
            this.l_Ped = l_Pedidos;
        }*/

        public w_Lista_Pedidos()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Pedido P = new Pedido();
            w_Det_Pedido w_Det = new w_Det_Pedido(P/*, l_Prod*/);
            w_Det.ShowDialog();

            /*if (P.Qtde_Total != 0) //Cadastrou!!!
            {
                this.l_Ped.Add(P);
            }*/
        }

        private void w_Lista_Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pedido> L_Ped = new List<Pedido>();
                List<string> L_PedImp = new List<string>();
                PedidoBD PedBD = new PedidoBD();

                L_Ped = PedBD.ListarTodos();
                
                foreach (Pedido P in L_Ped)
                {
                    int Cont = 1;
                    L_PedImp.Add("Cód: " + P.Codigo + " Qtde. Tot.:" + P.Qtde_Total + " Valor: " + P.Valor_Total);
                    foreach (Item_Pedido It in P.Lista_Itens)
                    {
                        L_PedImp.Add("   ["+Cont+"] -->" + It.Prod.Codigo + " ("+It.Prod.Desc + ") Qtde.:" + It.Qtde + " Preço Unit.: " + It.Preco_Unitario);
                        ++Cont;
                    }

                }

                w_Imp_Lista w_Imp = new w_Imp_Lista(L_PedImp, "Pedidos");
                w_Imp.ShowDialog();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Não foi possível carregar os pedidos do Oracle ({ex.Number}):\n{ex.Message}",
                                "Erro de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado ao listar pedidos:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
