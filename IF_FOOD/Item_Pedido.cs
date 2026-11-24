using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_FOOD
{
    public class Item_Pedido
    {
        public int IdPedido { get; set; }
        public Produto Prod { get; set; } 

        public int Qtde;
        public double Preco_Unitario;

        public Item_Pedido()
        {
            this.Prod = new Produto();
        }

        public Item_Pedido(int Id, Produto P, int Qtde, double PrecoUnit) : this()
        {
            this.IdPedido = Id;
            this.Prod = P;
            this.Qtde = Qtde;
            this.Preco_Unitario = PrecoUnit;
            this.Preco_Unitario = PrecoUnit;
        }

        public double Valor()
        {
            return this.Preco_Unitario * this.Qtde;
        }

        
    }
}
