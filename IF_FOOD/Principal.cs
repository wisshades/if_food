using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace IF_FOOD
{
    public partial class w_Principal : Form
    {
        bool sidebarExpand = true;

        const int larguraMaxima = 204;
        const int larguraMinima = 60;
        public w_Principal()
        {
            InitializeComponent();
        }

        private void w_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            string cpf = Regex.Replace(tb_Cpf.Text.Trim(), @"\D", "");
            string senha = tb_Senha.Text;

            if (cpf == ""|| senha == "")
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
                using (OracleConnection conexao = ConexaoOracle.ObterConexao())
                {
                    if (conexao.State != System.Data.ConnectionState.Open)
                    {
                        conexao.Open();
                    }

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

                    if (existeCPF == 0)
                    {
                        MessageBox.Show("CPF não encontrado no banco de dados!");
                        return;
                    }

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

                    if (loginValido == 0)
                    {
                        MessageBox.Show("Senha incorreta!");
                        return;
                    }

                    if (cpf == "53968518802" || cpf == "01234567890")
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width <= larguraMinima)
                {
                    SideBar.Width = larguraMinima;
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width >= larguraMaxima)
                {
                    SideBar.Width = larguraMaxima;
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            w_Principal Login = new w_Principal();
            Login.ShowDialog();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            w_Det_Cadastrar Cadastrar = new w_Det_Cadastrar();
            Cadastrar.ShowDialog();
        }

        private void p_Login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
