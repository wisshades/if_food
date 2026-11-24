using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_FOOD
{
    public class ConexaoOracle
    {
        private static readonly string _connectionString = "User Id=BRILPOO;Password=BRILPOO;Data Source=187.17.169.253:1521/XE;";

        public static OracleConnection ObterConexao()
        {
            var conn = new OracleConnection(_connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch(Exception E)
            {
                MessageBox.Show("Erro de conexão: " + E.Message);
                conn.Dispose();
                throw;
            }
        }
    }
}
