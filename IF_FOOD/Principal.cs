
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace IF_FOOD
{
    public partial class w_Principal : Form
    {
        public w_Principal()
        {
            InitializeComponent();
        }

        private void w_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            // Pega os dados digitados nos TextBoxes
            string cpf = Regex.Replace(tb_Cpf.Text.Trim(), @"\D", "");
            string senha = tb_Senha.Text;

            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(cpf) ||
                string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha o CPF e a senha!");
                return;
            }

            if (cpf.Length != 11)
            {
                MessageBox.Show("Digite um CPF válido com 11 números!");
                return;
            }

            try
            {
                // Obtém a conexão com o Oracle
                using (OracleConnection conexao = ConexaoOracle.ObterConexao())
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                    {
                        conexao.Open();
                    }

                    // 1. Verifica se o CPF existe no banco
                    string sqlCPF = @"
                        SELECT COUNT(*)
                        FROM G6_USUARIO
                        WHERE LPAD(
                            REGEXP_REPLACE(TO_CHAR(CPF), '[^0-9]', ''),
                            11,
                            '0'
                        ) = :cpf";

                    int existeCPF = 0;

                    using (OracleCommand comando = new OracleCommand(sqlCPF, conexao))
                    {
                        comando.BindByName = true;

                        comando.Parameters.Add("cpf", OracleDbType.Varchar2).Value = cpf;

                        existeCPF = Convert.ToInt32(comando.ExecuteScalar());
                    }

                    // Se o CPF não estiver cadastrado
                    if (existeCPF == 0)
                    {
                        MessageBox.Show("CPF não encontrado no banco de dados!");
                        return;
                    }

                    // 2. Verifica se a senha está correta
                    string sqlSenha = @"
                        SELECT COUNT(*)
                        FROM G6_USUARIO
                        WHERE LPAD(
                            REGEXP_REPLACE(TO_CHAR(CPF), '[^0-9]', ''),
                            11,
                            '0'
                        ) = :cpf
                        AND TRIM(TO_CHAR(SENHA)) = :senha";

                    int loginValido = 0;

                    using (OracleCommand comando = new OracleCommand(sqlSenha, conexao))
                    {
                        comando.BindByName = true;

                        comando.Parameters.Add("cpf", OracleDbType.Varchar2).Value = cpf;
                        comando.Parameters.Add("senha", OracleDbType.Varchar2).Value = senha;

                        loginValido = Convert.ToInt32(comando.ExecuteScalar());
                    }

                    // Se a senha estiver incorreta
                    if (loginValido == 0)
                    {
                        MessageBox.Show("Senha incorreta!");
                        return;
                    }

                    // 3. Verifica se é administrador ou usuário comum
                    if (cpf == "53968518802")
                    {
                        MessageBox.Show("Bem-vindo, administrador!");

                        this.Hide();

                        try
                        {
                            w_MenuAdm telaAdmin = new w_MenuAdm();
                            telaAdmin.ShowDialog();
                        }
                        finally
                        {
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login realizado com sucesso!");

                        this.Hide();

                        try
                        {
                            w_Lista_Pedidos telaPedido = new w_Lista_Pedidos();
                            telaPedido.ShowDialog();
                        }
                        finally
                        {
                            this.Show();
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(
                    "Erro na conexão ou consulta Oracle:\n" + ex.Message,
                    "Erro Oracle",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao realizar login:\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
