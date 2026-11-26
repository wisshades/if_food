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
            btn_Entrar = new Button();
            btn_Sair = new Button();
            tb_Senha = new TextBox();
            lbl_CPF = new Label();
            label7 = new Label();
            lbl_Senha = new Label();
            tb_Cpf = new MaskedTextBox();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            lbl_Bem = new Label();
            lbl_IF = new Label();
            lbl_food = new Label();
            lbl_Ola = new Label();
            SideBar = new FlowLayoutPanel();
            btn_Menu = new Button();
            btn_Login = new Button();
            btn_Cadastro = new Button();
            p_Login = new Panel();
            SideBar.SuspendLayout();
            p_Login.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Entrar
            // 
            btn_Entrar.BackColor = Color.MediumPurple;
            btn_Entrar.FlatStyle = FlatStyle.Flat;
            btn_Entrar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Entrar.ForeColor = SystemColors.ControlLightLight;
            btn_Entrar.Location = new Point(545, 297);
            btn_Entrar.Margin = new Padding(3, 2, 3, 2);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(125, 38);
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
            btn_Sair.Location = new Point(684, 297);
            btn_Sair.Margin = new Padding(4, 3, 4, 3);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(123, 35);
            btn_Sair.TabIndex = 25;
            btn_Sair.Text = "Fechar";
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // tb_Senha
            // 
            tb_Senha.Font = new Font("Microsoft Sans Serif", 11F);
            tb_Senha.HideSelection = false;
            tb_Senha.Location = new Point(545, 247);
            tb_Senha.Margin = new Padding(3, 2, 3, 2);
            tb_Senha.Name = "tb_Senha";
            tb_Senha.PasswordChar = '*';
            tb_Senha.Size = new Size(263, 24);
            tb_Senha.TabIndex = 27;
            tb_Senha.TextChanged += tb_Senha_TextChanged;
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.Location = new Point(545, 162);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(28, 15);
            lbl_CPF.TabIndex = 24;
            lbl_CPF.Text = "CPF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F);
            label7.ForeColor = Color.MediumPurple;
            label7.Location = new Point(638, 112);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
            label7.TabIndex = 28;
            label7.Text = "LOGIN";
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Location = new Point(545, 230);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(39, 15);
            lbl_Senha.TabIndex = 26;
            lbl_Senha.Text = "Senha";
            // 
            // tb_Cpf
            // 
            tb_Cpf.Font = new Font("Microsoft Sans Serif", 11F);
            tb_Cpf.HideSelection = false;
            tb_Cpf.Location = new Point(545, 180);
            tb_Cpf.Margin = new Padding(4, 3, 4, 3);
            tb_Cpf.Mask = "000,000,000-00";
            tb_Cpf.Name = "tb_Cpf";
            tb_Cpf.Size = new Size(263, 24);
            tb_Cpf.TabIndex = 29;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // lbl_Bem
            // 
            lbl_Bem.AutoSize = true;
            lbl_Bem.Font = new Font("Microsoft Sans Serif", 26.75F, FontStyle.Bold);
            lbl_Bem.ForeColor = SystemColors.ControlLightLight;
            lbl_Bem.Location = new Point(243, 184);
            lbl_Bem.Margin = new Padding(4, 0, 4, 0);
            lbl_Bem.Name = "lbl_Bem";
            lbl_Bem.Size = new Size(205, 40);
            lbl_Bem.TabIndex = 32;
            lbl_Bem.Text = "bem-vindo!";
            // 
            // lbl_IF
            // 
            lbl_IF.AutoSize = true;
            lbl_IF.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IF.ForeColor = SystemColors.ControlLightLight;
            lbl_IF.Location = new Point(298, 100);
            lbl_IF.Margin = new Padding(4, 0, 4, 0);
            lbl_IF.Name = "lbl_IF";
            lbl_IF.Size = new Size(32, 25);
            lbl_IF.TabIndex = 33;
            lbl_IF.Text = "IF";
            // 
            // lbl_food
            // 
            lbl_food.AutoSize = true;
            lbl_food.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_food.ForeColor = SystemColors.ControlLightLight;
            lbl_food.Location = new Point(323, 104);
            lbl_food.Margin = new Padding(4, 0, 4, 0);
            lbl_food.Name = "lbl_food";
            lbl_food.Size = new Size(41, 20);
            lbl_food.TabIndex = 34;
            lbl_food.Text = "food";
            // 
            // lbl_Ola
            // 
            lbl_Ola.AutoSize = true;
            lbl_Ola.Font = new Font("Microsoft Sans Serif", 26.75F, FontStyle.Bold);
            lbl_Ola.ForeColor = SystemColors.ControlLightLight;
            lbl_Ola.Location = new Point(243, 141);
            lbl_Ola.Margin = new Padding(4, 0, 4, 0);
            lbl_Ola.Name = "lbl_Ola";
            lbl_Ola.Size = new Size(87, 40);
            lbl_Ola.TabIndex = 35;
            lbl_Ola.Text = "Olá,";
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.DarkSlateBlue;
            SideBar.Controls.Add(btn_Menu);
            SideBar.Controls.Add(btn_Login);
            SideBar.Controls.Add(btn_Cadastro);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(206, 522);
            SideBar.TabIndex = 36;
            // 
            // btn_Menu
            // 
            btn_Menu.FlatAppearance.BorderSize = 0;
            btn_Menu.FlatStyle = FlatStyle.Flat;
            btn_Menu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Menu.ForeColor = Color.White;
            btn_Menu.Location = new Point(3, 3);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(201, 49);
            btn_Menu.TabIndex = 0;
            btn_Menu.Text = "Menu";
            btn_Menu.UseVisualStyleBackColor = true;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // btn_Login
            // 
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(3, 58);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(201, 49);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Cadastro
            // 
            btn_Cadastro.FlatAppearance.BorderSize = 0;
            btn_Cadastro.FlatStyle = FlatStyle.Flat;
            btn_Cadastro.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Cadastro.ForeColor = Color.White;
            btn_Cadastro.Location = new Point(3, 113);
            btn_Cadastro.Name = "btn_Cadastro";
            btn_Cadastro.Size = new Size(201, 49);
            btn_Cadastro.TabIndex = 2;
            btn_Cadastro.Text = "Cadastrar";
            btn_Cadastro.UseVisualStyleBackColor = true;
            btn_Cadastro.Click += btn_Cadastro_Click;
            // 
            // p_Login
            // 
            p_Login.BackColor = Color.MediumPurple;
            p_Login.Controls.Add(lbl_Ola);
            p_Login.Controls.Add(lbl_food);
            p_Login.Controls.Add(lbl_IF);
            p_Login.Controls.Add(lbl_Bem);
            p_Login.Location = new Point(0, 0);
            p_Login.Margin = new Padding(3, 2, 3, 2);
            p_Login.Name = "p_Login";
            p_Login.Size = new Size(468, 553);
            p_Login.TabIndex = 2;
            p_Login.Paint += p_Login_Paint;
            // 
            // w_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 522);
            Controls.Add(SideBar);
            Controls.Add(p_Login);
            Controls.Add(lbl_Senha);
            Controls.Add(btn_Sair);
            Controls.Add(lbl_CPF);
            Controls.Add(label7);
            Controls.Add(btn_Entrar);
            Controls.Add(tb_Senha);
            Controls.Add(tb_Cpf);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "w_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IF_FOOD - Restaurante";
            SideBar.ResumeLayout(false);
            p_Login.ResumeLayout(false);
            p_Login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHome;
        private Label label6;
        private Label label1;
        private Button btn_Entrar;
        private Button btn_Sair;
        private TextBox tb_Senha;
        private Label lbl_CPF;
        private Label label7;
        private Label lbl_Senha;
        private MaskedTextBox tb_Cpf;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Label lbl_Bem;
        private Label lbl_IF;
        private Label lbl_food;
        private Label lbl_Ola;
        private FlowLayoutPanel SideBar;
        private Button btn_Menu;
        private Button btn_Login;
        private Button btn_Cadastro;
        private Panel p_Login;
    }
}
