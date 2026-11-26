using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_FOOD
{
    public class Item_PedidoBD
    {

        public List<Item_Pedido> ListarTodos(int IdPedido)
        {
            List<Item_Pedido> lista = new List<Item_Pedido>();

            using (OracleConnection conn = ConexaoOracle.ObterConexao())
            using (OracleCommand cmd = new OracleCommand("SELECT * FROM ITEM_PEDIDO WHERE ID_PEDIDO = :ID_PEDIDO ORDER BY ROWID", conn))
            {
                cmd.Parameters.Add("ID_PEDIDO", OracleDbType.Int32).Value = IdPedido;
                using (OracleDataReader reader = cmd.ExecuteReader())

                    while (reader != null && reader.Read())
                    {
                        int IdProduto = reader.GetInt32(1);
                        using (OracleCommand cmdProd = new OracleCommand("SELECT * FROM PRODUTO WHERE ID_PRODUTO = :ID_PRODUTO", conn))
                        {
                            cmdProd.Parameters.Add("ID_PRODUTO", OracleDbType.Int32).Value = IdProduto;
                            using (OracleDataReader readerProd = cmdProd.ExecuteReader())

                                if (readerProd != null && readerProd.Read())
                                {
                                    Produto Prod = new Produto(reader.GetInt32(0), reader.GetString(1),
                                                reader.GetString(2), reader.GetInt32(3),
                                               reader.GetString(4), reader.GetString(5), reader.GetDouble(6));

                                    lista.Add(new Item_Pedido(reader.GetInt32(0), Prod,
                                                        reader.GetInt32(2), reader.GetDouble(3)));
                                }

                        }
                    }
            }

            return lista;
        }
    }
}