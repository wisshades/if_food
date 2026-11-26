using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_FOOD
{
    public class PedidoBD
    {
        public List<Pedido> ListarTodos()
        {
            Item_PedidoBD ItPedBD = new Item_PedidoBD();
            List<Pedido> lista = new List<Pedido>();

            using (OracleConnection conn = ConexaoOracle.ObterConexao())
            using (OracleCommand cmd = new OracleCommand("SELECT * FROM PEDIDO ORDER BY CODIGO", conn))
            using (OracleDataReader reader = cmd.ExecuteReader())

                while (reader != null && reader.Read())
                {
                    Pedido Ped = new Pedido(reader.GetInt32(0), reader.GetString(1),
                                        reader.GetInt32(2), reader.GetDouble(3));

                    Ped.Lista_Itens = ItPedBD.ListarTodos(Ped.Id_Pedido);

                    lista.Add(Ped);
                }

            return lista;
        }

        public void Atualizar(Pedido pedido)
        {
            using OracleConnection conn = ConexaoOracle.ObterConexao();

            using var transaction = conn.BeginTransaction();

            try
            {
                string sqlPed;

                if (pedido.Id_Pedido == 0)
                {
                    sqlPed = @"INSERT INTO PEDIDO (QTDE_TOTAL, VALOR_TOTAL) VALUES (:QTDE, :VALOR) 
                                RETURNING ID_PEDIDO INTO :ID_PEDIDO";
                }
                else
                {
                    sqlPed = @"UPDATE PEDIDO 
                               SET QTDE_TOTAL = :QTDE
                                   BALOR_TOTAL = :VALOR
                             WHERE ID_PEDIDO = :ID_PEDIDO";
                }


                using OracleCommand cmd = new OracleCommand(sqlPed, conn);
                {
                    cmd.Transaction = transaction;
                    cmd.BindByName = true;

                    cmd.Parameters.Add("QTDE", OracleDbType.Int32).Value = pedido.Qtde_Total;
                    cmd.Parameters.Add("VALOR", OracleDbType.Decimal).Value = pedido.Valor_Total;

                    OracleParameter paramId = new OracleParameter("ID_PEDIDO", OracleDbType.Int32)
                    {
                        Direction = (pedido.Id_Pedido == 0) ? System.Data.ParameterDirection.Output :
                                    System.Data.ParameterDirection.Input
                    };

                    cmd.Parameters.Add(paramId);
                    if (pedido.Id_Pedido > 0)
                    {
                        paramId.Value = pedido.Id_Pedido;
                    }

                    cmd.ExecuteNonQuery();
                    pedido.Id_Pedido = Convert.ToInt32(paramId.Value.ToString());
                }

                const string sqlDelItens = @"DELETE FROM ITEM_PEDIDO 
                                                    WHERE ID_PEDIDO =:ID_PED";

                using (var cmdDelItens = new OracleCommand(sqlDelItens, conn))
                {
                    cmdDelItens.Transaction = transaction;
                    cmdDelItens.BindByName = true;

                    cmdDelItens.Parameters.Add("ID_PED", OracleDbType.Int32).Value = pedido.Id_Pedido;

                    cmdDelItens.ExecuteNonQuery();
                }

                const string sqlItem = @"
                INSERT INTO ITEM_PEDIDO (ID_PEDIDO, ID_PRODUTO, QTDE, PRECO_UNITARIO) 
                VALUES (:ID_PED, :ID_PROD, :QTDE, :PRECO_UNI)";

                using (var cmdItem = new OracleCommand(sqlItem, conn))
                {
                    cmdItem.Transaction = transaction;
                    cmdItem.BindByName = true;

                    var IdPed = cmdItem.Parameters.Add("ID_PED", OracleDbType.Int32);
                    var IdProd = cmdItem.Parameters.Add("ID_PROD", OracleDbType.Int32);
                    var Qtde = cmdItem.Parameters.Add("QTDE", OracleDbType.Int32);
                    var Preco_Uni = cmdItem.Parameters.Add("PRECO_UNI", OracleDbType.Decimal);

                    foreach (Item_Pedido It in pedido.Lista_Itens)
                    {
                        IdPed.Value = pedido.Id_Pedido;
                        IdProd.Value = It.Prod.Id_Produto;
                        Qtde.Value = It.Qtde;
                        Preco_Uni.Value = It.Preco_Unitario;

                        cmdItem.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

    }
}