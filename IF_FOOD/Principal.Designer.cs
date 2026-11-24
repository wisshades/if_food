namespace IF_FOOD
{
    partial class w_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            p_Login = new Panel();
            lbl_Ola = new Label();
            lbl_food = new Label();
            lbl_IF = new Label();
            lbl_Bem = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btn_Entrar = new Button();
            btn_Sair = new Button();
            tb_Senha = new TextBox();
            lbl_CPF = new Label();
            label7 = new Label();
            lbl_Senha = new Label();
            tb_Cpf = new MaskedTextBox();
            p_Login.SuspendLayout();
            SuspendLayout();
            // 
            // p_Login
            // 
            p_Login.BackColor = Color.MediumPurple;
            p_Login.Controls.Add(lbl_Ola);
            p_Login.Controls.Add(lbl_food);
            p_Login.Controls.Add(lbl_IF);
            p_Login.Controls.Add(lbl_Bem);
            p_Login.Location = new Point(-4, -7);
            p_Login.Name = "p_Login";
            p_Login.Size = new Size(488, 700);
            p_Login.TabIndex = 2;
            // 
            // lbl_Ola
            // 
            lbl_Ola.AutoSize = true;
            lbl_Ola.Font = new Font("Microsoft Sans Serif", 26.75F, FontStyle.Bold);
            lbl_Ola.ForeColor = SystemColors.ControlLightLight;
            lbl_Ola.Location = new Point(81, 142);
            lbl_Ola.Margin = new Padding(4, 0, 4, 0);
            lbl_Ola.Name = "lbl_Ola";
            lbl_Ola.Size = new Size(87, 40);
            lbl_Ola.TabIndex = 35;
            lbl_Ola.Text = "Olá,";
            // 
            // lbl_food
            // 
            lbl_food.AutoSize = true;
            lbl_food.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_food.ForeColor = SystemColors.ControlLightLight;
            lbl_food.Location = new Point(126, 89);
            lbl_food.Margin = new Padding(4, 0, 4, 0);
            lbl_food.Name = "lbl_food";
            lbl_food.Size = new Size(41, 20);
            lbl_food.TabIndex = 34;
            lbl_food.Text = "food";
            // 
            // lbl_IF
            // 
            lbl_IF.AutoSize = true;
            lbl_IF.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IF.ForeColor = SystemColors.ControlLightLight;
            lbl_IF.Location = new Point(99, 84);
            lbl_IF.Margin = new Padding(4, 0, 4, 0);
            lbl_IF.Name = "lbl_IF";
            lbl_IF.Size = new Size(32, 25);
            lbl_IF.TabIndex = 33;
            lbl_IF.Text = "IF";
            // 
            // lbl_Bem
            // 
            lbl_Bem.AutoSize = true;
            lbl_Bem.Font = new Font("Microsoft Sans Serif", 26.75F, FontStyle.Bold);
            lbl_Bem.ForeColor = SystemColors.ControlLightLight;
            lbl_Bem.Location = new Point(99, 190);
            lbl_Bem.Margin = new Padding(4, 0, 4, 0);
            lbl_Bem.Name = "lbl_Bem";
            lbl_Bem.Size = new Size(205, 40);
            lbl_Bem.TabIndex = 32;
            lbl_Bem.Text = "bem-vindo!";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btn_Entrar
            // 
            btn_Entrar.BackColor = Color.MediumPurple;
            btn_Entrar.FlatStyle = FlatStyle.Flat;
            btn_Entrar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Entrar.ForeColor = SystemColors.ControlLightLight;
            btn_Entrar.Location = new Point(678, 346);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(143, 48);
            btn_Entrar.TabIndex = 23;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = false;
            btn_Entrar.Click += btn_Entrar_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.BackColor = Color.White;
            btn_Sair.FlatStyle = FlatStyle.Flat;
            btn_Sair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Sair.ForeColor = Color.FromArgb(147, 122, 219);
            btn_Sair.Location = new Point(837, 346);
            btn_Sair.Margin = new Padding(4);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(141, 45);
            btn_Sair.TabIndex = 25;
            btn_Sair.Text = "Fechar";
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // tb_Senha
            // 
            tb_Senha.Font = new Font("Microsoft Sans Serif", 11F);
            tb_Senha.Location = new Point(678, 282);
            tb_Senha.Name = "tb_Senha";
            tb_Senha.Size = new Size(300, 24);
            tb_Senha.TabIndex = 27;
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.Location = new Point(678, 175);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(33, 19);
            lbl_CPF.TabIndex = 24;
            lbl_CPF.Text = "CPF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F);
            label7.ForeColor = Color.MediumPurple;
            label7.Location = new Point(784, 111);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 28;
            label7.Text = "LOGIN";
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Location = new Point(678, 260);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(46, 19);
            lbl_Senha.TabIndex = 26;
            lbl_Senha.Text = "Senha";
            // 
            // tb_Cpf
            // 
            tb_Cpf.Font = new Font("Microsoft Sans Serif", 11F);
            tb_Cpf.Location = new Point(678, 198);
            tb_Cpf.Margin = new Padding(4);
            tb_Cpf.Mask = "000,000,000-00";
            tb_Cpf.Name = "tb_Cpf";
            tb_Cpf.PasswordChar = '*';
            tb_Cpf.Size = new Size(300, 24);
            tb_Cpf.TabIndex = 29;
            // 
            // w_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(tb_Cpf);
            Controls.Add(label7);
            Controls.Add(tb_Senha);
            Controls.Add(btn_Entrar);
            Controls.Add(btn_Sair);
            Controls.Add(lbl_CPF);
            Controls.Add(lbl_Senha);
            Controls.Add(p_Login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "w_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IF_FOOD - Restaurante";
            Load += w_Principal_Load;
            p_Login.ResumeLayout(false);
            p_Login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel p_Login;
        private Label lblHome;
        private Label label6;
        private Label label1;
        private Label lbl_IF;
        private Label lbl_Bem;
        private Label lbl_Ola;
        private Label lbl_food;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_Entrar;
        private Button btn_Sair;
        private TextBox tb_Senha;
        private Label lbl_CPF;
        private Label label7;
        private Label lbl_Senha;
        private MaskedTextBox tb_Cpf;
    }
}
