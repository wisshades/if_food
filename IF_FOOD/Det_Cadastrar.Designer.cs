namespace IF_FOOD
{
    partial class w_Det_Cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            p_Login = new Panel();
            SideBarCad = new FlowLayoutPanel();
            btn_Menu_Cad = new Button();
            btn_Login_Cad = new Button();
            btn_Cadastro_Cad = new Button();
            lbl_Ola = new Label();
            lbl_food = new Label();
            lbl_IF = new Label();
            lbl_Bem = new Label();
            tb_CpfCad = new MaskedTextBox();
            lbl_Cadastro = new Label();
            tb_SenhaCad = new TextBox();
            btn_Cadastrar = new Button();
            btn_Sair = new Button();
            lbl_CPFCad = new Label();
            lbl_Senha_Cad = new Label();
            tb_EmailCad = new TextBox();
            lbl_Nome = new Label();
            lbl_Email = new Label();
            sidebartimerCad = new System.Windows.Forms.Timer(components);
            tb_NomeCad = new TextBox();
            p_Login.SuspendLayout();
            SideBarCad.SuspendLayout();
            SuspendLayout();
            // 
            // p_Login
            // 
            p_Login.BackColor = Color.MediumPurple;
            p_Login.Controls.Add(SideBarCad);
            p_Login.Controls.Add(lbl_Ola);
            p_Login.Controls.Add(lbl_food);
            p_Login.Controls.Add(lbl_IF);
            p_Login.Controls.Add(lbl_Bem);
            p_Login.Location = new Point(-6, -4);
            p_Login.Margin = new Padding(3, 2, 3, 2);
            p_Login.Name = "p_Login";
            p_Login.Size = new Size(433, 559);
            p_Login.TabIndex = 3;
            // 
            // SideBarCad
            // 
            SideBarCad.BackColor = Color.DarkSlateBlue;
            SideBarCad.Controls.Add(btn_Menu_Cad);
            SideBarCad.Controls.Add(btn_Login_Cad);
            SideBarCad.Controls.Add(btn_Cadastro_Cad);
            SideBarCad.Dock = DockStyle.Left;
            SideBarCad.Location = new Point(0, 0);
            SideBarCad.Name = "SideBarCad";
            SideBarCad.Size = new Size(204, 559);
            SideBarCad.TabIndex = 36;
            // 
            // btn_Menu_Cad
            // 
            btn_Menu_Cad.FlatStyle = FlatStyle.Flat;
            btn_Menu_Cad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Menu_Cad.ForeColor = Color.White;
            btn_Menu_Cad.Location = new Point(3, 3);
            btn_Menu_Cad.Name = "btn_Menu_Cad";
            btn_Menu_Cad.Size = new Size(201, 49);
            btn_Menu_Cad.TabIndex = 0;
            btn_Menu_Cad.Text = "Menu";
            btn_Menu_Cad.UseVisualStyleBackColor = true;
            btn_Menu_Cad.Click += btn_Menu_Cad_Click;
            // 
            // btn_Login_Cad
            // 
            btn_Login_Cad.FlatStyle = FlatStyle.Flat;
            btn_Login_Cad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Login_Cad.ForeColor = Color.White;
            btn_Login_Cad.Location = new Point(3, 58);
            btn_Login_Cad.Name = "btn_Login_Cad";
            btn_Login_Cad.Size = new Size(201, 49);
            btn_Login_Cad.TabIndex = 1;
            btn_Login_Cad.Text = "LOGIN";
            btn_Login_Cad.UseVisualStyleBackColor = true;
            btn_Login_Cad.Click += btn_Login_Cad_Click;
            // 
            // btn_Cadastro_Cad
            // 
            btn_Cadastro_Cad.FlatStyle = FlatStyle.Flat;
            btn_Cadastro_Cad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Cadastro_Cad.ForeColor = Color.White;
            btn_Cadastro_Cad.Location = new Point(3, 113);
            btn_Cadastro_Cad.Name = "btn_Cadastro_Cad";
            btn_Cadastro_Cad.Size = new Size(201, 49);
            btn_Cadastro_Cad.TabIndex = 2;
            btn_Cadastro_Cad.Text = "Cadastrar";
            btn_Cadastro_Cad.UseVisualStyleBackColor = true;
            // 
            // lbl_Ola
            // 
            lbl_Ola.AutoSize = true;
            lbl_Ola.Font = new Font("Microsoft Sans Serif", 26.75F, FontStyle.Bold);
            lbl_Ola.ForeColor = SystemColors.ControlLightLight;
            lbl_Ola.Location = new Point(206, 142);
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
            lbl_food.Location = new Point(286, 105);
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
            lbl_IF.Location = new Point(261, 101);
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
            lbl_Bem.Location = new Point(206, 185);
            lbl_Bem.Margin = new Padding(4, 0, 4, 0);
            lbl_Bem.Name = "lbl_Bem";
            lbl_Bem.Size = new Size(205, 40);
            lbl_Bem.TabIndex = 32;
            lbl_Bem.Text = "bem-vindo!";
            // 
            // tb_CpfCad
            // 
            tb_CpfCad.Font = new Font("Microsoft Sans Serif", 11F);
            tb_CpfCad.HideSelection = false;
            tb_CpfCad.Location = new Point(543, 268);
            tb_CpfCad.Margin = new Padding(4, 3, 4, 3);
            tb_CpfCad.Mask = "000,000,000-00";
            tb_CpfCad.Name = "tb_CpfCad";
            tb_CpfCad.Size = new Size(263, 24);
            tb_CpfCad.TabIndex = 36;
            // 
            // lbl_Cadastro
            // 
            lbl_Cadastro.AutoSize = true;
            lbl_Cadastro.Font = new Font("Microsoft Sans Serif", 14F);
            lbl_Cadastro.ForeColor = Color.MediumPurple;
            lbl_Cadastro.Location = new Point(616, 79);
            lbl_Cadastro.Margin = new Padding(4, 0, 4, 0);
            lbl_Cadastro.Name = "lbl_Cadastro";
            lbl_Cadastro.Size = new Size(114, 24);
            lbl_Cadastro.TabIndex = 35;
            lbl_Cadastro.Text = "CADASTRO";
            // 
            // tb_SenhaCad
            // 
            tb_SenhaCad.Font = new Font("Microsoft Sans Serif", 11F);
            tb_SenhaCad.HideSelection = false;
            tb_SenhaCad.Location = new Point(543, 334);
            tb_SenhaCad.Margin = new Padding(3, 2, 3, 2);
            tb_SenhaCad.Name = "tb_SenhaCad";
            tb_SenhaCad.Size = new Size(263, 24);
            tb_SenhaCad.TabIndex = 34;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.MediumPurple;
            btn_Cadastrar.FlatStyle = FlatStyle.Flat;
            btn_Cadastrar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cadastrar.ForeColor = SystemColors.ControlLightLight;
            btn_Cadastrar.Location = new Point(543, 394);
            btn_Cadastrar.Margin = new Padding(3, 2, 3, 2);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(125, 38);
            btn_Cadastrar.TabIndex = 30;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.BackColor = Color.White;
            btn_Sair.FlatStyle = FlatStyle.Flat;
            btn_Sair.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Sair.ForeColor = Color.FromArgb(147, 122, 219);
            btn_Sair.Location = new Point(683, 394);
            btn_Sair.Margin = new Padding(4, 3, 4, 3);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(123, 35);
            btn_Sair.TabIndex = 32;
            btn_Sair.Text = "Fechar";
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // lbl_CPFCad
            // 
            lbl_CPFCad.AutoSize = true;
            lbl_CPFCad.Location = new Point(543, 246);
            lbl_CPFCad.Name = "lbl_CPFCad";
            lbl_CPFCad.Size = new Size(28, 15);
            lbl_CPFCad.TabIndex = 31;
            lbl_CPFCad.Text = "CPF";
            // 
            // lbl_Senha_Cad
            // 
            lbl_Senha_Cad.AutoSize = true;
            lbl_Senha_Cad.Location = new Point(543, 317);
            lbl_Senha_Cad.Name = "lbl_Senha_Cad";
            lbl_Senha_Cad.Size = new Size(39, 15);
            lbl_Senha_Cad.TabIndex = 33;
            lbl_Senha_Cad.Text = "Senha";
            // 
            // tb_EmailCad
            // 
            tb_EmailCad.Font = new Font("Microsoft Sans Serif", 11F);
            tb_EmailCad.HideSelection = false;
            tb_EmailCad.Location = new Point(543, 200);
            tb_EmailCad.Margin = new Padding(3, 2, 3, 2);
            tb_EmailCad.Name = "tb_EmailCad";
            tb_EmailCad.Size = new Size(263, 24);
            tb_EmailCad.TabIndex = 39;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(543, 119);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(40, 15);
            lbl_Nome.TabIndex = 37;
            lbl_Nome.Text = "Nome";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(543, 183);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(36, 15);
            lbl_Email.TabIndex = 38;
            lbl_Email.Text = "Email";
            // 
            // sidebartimerCad
            // 
            sidebartimerCad.Interval = 10;
            sidebartimerCad.Tick += sidebartimerCad_Tick;
            // 
            // tb_NomeCad
            // 
            tb_NomeCad.Font = new Font("Microsoft Sans Serif", 11F);
            tb_NomeCad.HideSelection = false;
            tb_NomeCad.Location = new Point(543, 138);
            tb_NomeCad.Margin = new Padding(3, 2, 3, 2);
            tb_NomeCad.Name = "tb_NomeCad";
            tb_NomeCad.Size = new Size(263, 24);
            tb_NomeCad.TabIndex = 40;
            // 
            // w_Det_Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 522);
            Controls.Add(tb_NomeCad);
            Controls.Add(tb_EmailCad);
            Controls.Add(lbl_Nome);
            Controls.Add(lbl_Email);
            Controls.Add(tb_CpfCad);
            Controls.Add(lbl_Cadastro);
            Controls.Add(tb_SenhaCad);
            Controls.Add(btn_Cadastrar);
            Controls.Add(btn_Sair);
            Controls.Add(lbl_CPFCad);
            Controls.Add(lbl_Senha_Cad);
            Controls.Add(p_Login);
            Name = "w_Det_Cadastrar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "w_Det_Cadastrar";
            p_Login.ResumeLayout(false);
            p_Login.PerformLayout();
            SideBarCad.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel p_Login;
        private FlowLayoutPanel SideBarCad;
        private Button btn_Menu_Cad;
        private Button btn_Login_Cad;
        private Button btn_Cadastro_Cad;
        private Label lbl_Ola;
        private Label lbl_food;
        private Label lbl_IF;
        private Label lbl_Bem;
        private MaskedTextBox tb_CpfCad;
        private Label lbl_Cadastro;
        private TextBox tb_SenhaCad;
        private Button btn_Cadastrar;
        private Button btn_Sair;
        private Label lbl_CPFCad;
        private Label lbl_Senha_Cad;
        private MaskedTextBox maskedTextBox1;
        private TextBox tb_EmailCad;
        private Label lbl_Nome;
        private Label lbl_Email;
        private System.Windows.Forms.Timer sidebartimerCad;
        private TextBox tb_NomeCad;
    }
}