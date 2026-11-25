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
    public partial class w_Det_Cadastrar : Form
    {
        bool sidebarExpand = true;

        const int larguraMaxima = 204;
        const int larguraMinima = 60;
        public w_Det_Cadastrar()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sidebartimerCad_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Se está aberto, vai diminuindo a largura de 10 em 10 pixels
                SideBarCad.Width -= 10;
                if (SideBarCad.Width <= larguraMinima)
                {
                    SideBarCad.Width = larguraMinima;
                    sidebarExpand = false;
                    sidebartimerCad.Stop(); // Para a animação
                }
            }
            else
            {
                // Se está fechado, vai aumentando a largura de 10 em 10 pixels
                SideBarCad.Width += 10;
                if (SideBarCad.Width >= larguraMaxima)
                {
                    SideBarCad.Width = larguraMaxima;
                    sidebarExpand = true;
                    sidebartimerCad.Stop(); // Para a animação
                }
            }
        }

        private void btn_Menu_Cad_Click(object sender, EventArgs e)
        {
            sidebartimerCad.Start();
        }

        private void btn_Login_Cad_Click(object sender, EventArgs e)
        {
            w_Principal Login = new w_Principal();
            Login.ShowDialog();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (tb_CpfCad.Text == "" || tb_NomeCad.Text == "" || tb_EmailCad.Text == "" || tb_SenhaCad.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Cria o objeto e joga os valores vindos dos TextBoxes com final Cad
                User_BD novoUsuario = new User_BD
                {
                    CPF = tb_CpfCad.Text.Trim(),
                    NOME = tb_NomeCad.Text.Trim(),
                    EMAIL = tb_EmailCad.Text.Trim(),
                    SENHA = tb_SenhaCad.Text.Trim()
                };

                // Chama o método Inserir da sua classe User_BD para ir para o Oracle
                novoUsuario.Inserir(novoUsuario);

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos e volta o foco para o primeiro
                tb_CpfCad.Clear();
                tb_NomeCad.Clear();
                tb_EmailCad.Clear();
                tb_SenhaCad.Clear();
                tb_CpfCad.Focus();

                this.Close(); // Fecha a tela de cadastro após salvar (opcional)
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Erro no banco Oracle (" + ex.Number + "): " + ex.Message, "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
