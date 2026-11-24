using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_FOOD
{
    public class Pedido
    {
        //static int ult_ref_id = 0;

        public int Id_Pedido { get; set; }

        public string Codigo { get; set; } = "";
        public int Qtde_Total { get; set; } = 0;
        public double Valor_Total { get; set; } = 0;

        public List<Item_Pedido> Lista_Itens { get; set; }

        public Pedido()
        {
            //Pedido.Gera_Id();
            //this.id_Pedido = Pedido.Get_Id();
            //this.Codigo += this.id_Pedido.ToString();
            this.Lista_Itens = new List<Item_Pedido>();
        }

        public Pedido(int Id, string Codigo, int Qtde_Tot, double Valor) : this()
        {
            this.Id_Pedido = Id;
            this.Codigo = Codigo;
            this.Qtde_Total = Qtde_Tot;
            this.Valor_Total = Valor;
        }


        /*static public void Gera_Id()
        {
            ++Pedido.ult_ref_id;
        }

        static public int Get_Id()
        {
            return Pedido.ult_ref_id;
        }*/
    }
}
