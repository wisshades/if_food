using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace IF_FOOD
{
    internal class User_BD
    {
        public string CPF { get; set; }
        public string NOME { get; set; }
        public string EMAIL { get; set; }
        public string SENHA { get; set; }
        public string CEP { get; set; }


        // MÉTODO PARA CADASTRAR USUÁRIO
        public void Inserir(User_BD usuario)
        {
            const string sql = @"
            INSERT INTO G6_USUARIO
            (CPF, NOME, EMAIL, SENHA, CEP)
            VALUES
            (:CPF, :NOME, :EMAIL, :SENHA, :CEP)";

            using (OracleConnection conn = ConexaoOracle.ObterConexao())
            using (OracleCommand cmd = new OracleCommand(sql, conn))
            {
                cmd.BindByName = true;

                cmd.Parameters.Add("CPF", OracleDbType.Varchar2).Value = usuario.CPF;
                cmd.Parameters.Add("NOME", OracleDbType.Varchar2).Value = usuario.NOME;
                cmd.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = usuario.EMAIL;
                cmd.Parameters.Add("SENHA", OracleDbType.Varchar2).Value = usuario.SENHA;
                cmd.Parameters.Add("CEP", OracleDbType.Varchar2).Value =
                    (object)usuario.CEP ?? DBNull.Value;

                cmd.ExecuteNonQuery();
            }
        }



        // MÉTODO PARA VERIFICAR LOGIN
        public User_BD VerificarLogin(string email, string senha)
        {
            User_BD usuario = null;

            const string sql = @"
            SELECT CPF, NOME, EMAIL, SENHA, CEP
            FROM G6_USUARIO
            WHERE EMAIL = :EMAIL
            AND SENHA = :SENHA";

            using (OracleConnection conn = ConexaoOracle.ObterConexao())
            using (OracleCommand cmd = new OracleCommand(sql, conn))
            {
                cmd.BindByName = true;

                cmd.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = email;
                cmd.Parameters.Add("SENHA", OracleDbType.Varchar2).Value = senha;

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new User_BD();

                        usuario.CPF = reader["CPF"].ToString();
                        usuario.NOME = reader["NOME"].ToString();
                        usuario.EMAIL = reader["EMAIL"].ToString();
                        usuario.SENHA = reader["SENHA"].ToString();
                        usuario.CEP = reader["CEP"] == DBNull.Value
                            ? null
                            : reader["CEP"].ToString();
                    }
                }
            }

            return usuario;
        }
        /*public bool ValidarLogin(string cpf, string senha)
        {
            /*using (OracleConnection conn = ConexaoOracle.ObterConexao())
            using (OracleCommand cmd = new OracleCommand(
                "SELECT COUNT(*) FROM G6_USUARIO WHERE CPF = :CPF AND SENHA = :SENHA", conn))
            {
                cmd.Parameters.Add("CPF", OracleDbType.Varchar2).Value = cpf;
                cmd.Parameters.Add("SENHA", OracleDbType.Varchar2).Value = senha;

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                return resultado > 0;
            }

        }*/
    }
}