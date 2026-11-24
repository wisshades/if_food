using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_FOOD
{
    public class Produto
    {
        //static int ult_ref_id=0;

        public int Id_Produto { get; set; }

        public string Codigo { get; set; } = "";
        public string Desc { get; set; } = "";
        public int Qtde { get; set; } = 0;
        public double Preco { get; set; } = 0;

        /*static public void Gera_Id()
        {
            ++Produto.ult_ref_id;
        }*/

        /*static public int Get_Id()
        {
            return Produto.ult_ref_id;
        }*/

        public Produto()
        {
            //Produto.Gera_Id();
            //this.id_Produto = Produto.Get_Id();
            //this.Codigo += this.id_Produto.ToString();
        }

        public Produto(int Id, string Codigo, string Desc, int Qtde, double Preco):this()
        {
            this.Id_Produto = Id;
            this.Codigo = Codigo;
            this.Desc = Desc;
            this.Qtde = Qtde;
            this.Preco = Preco;
        }
    }
}
