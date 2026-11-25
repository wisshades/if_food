namespace IF_FOOD
{
    partial class w_MenuAdm
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
            panelMenuAdm = new Panel();
            pictureBox1 = new PictureBox();
            btn_sair = new Button();
            btn_relatorio = new Button();
            btn_produtos = new Button();
            btn_Dashbord = new Button();
            dataGridView1 = new DataGridView();
            btn_adicionar = new Button();
            txt_Pesquisar = new TextBox();
            lbl_menuAdm = new Label();
            Id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            panelMenuAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelMenuAdm
            // 
            panelMenuAdm.BackColor = Color.FromArgb(64, 0, 64);
            panelMenuAdm.Controls.Add(pictureBox1);
            panelMenuAdm.Controls.Add(btn_sair);
            panelMenuAdm.Controls.Add(btn_relatorio);
            panelMenuAdm.Controls.Add(btn_produtos);
            panelMenuAdm.Controls.Add(btn_Dashbord);
            panelMenuAdm.Location = new Point(6, 7);
            panelMenuAdm.Name = "panelMenuAdm";
            panelMenuAdm.Size = new Size(167, 630);
            panelMenuAdm.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 93);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(6, 414);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(158, 54);
            btn_sair.TabIndex = 3;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_relatorio
            // 
            btn_relatorio.Location = new Point(6, 354);
            btn_relatorio.Name = "btn_relatorio";
            btn_relatorio.Size = new Size(158, 54);
            btn_relatorio.TabIndex = 2;
            btn_relatorio.Text = "Relatórios";
            btn_relatorio.UseVisualStyleBackColor = true;
            // 
            // btn_produtos
            // 
            btn_produtos.Location = new Point(6, 294);
            btn_produtos.Name = "btn_produtos";
            btn_produtos.Size = new Size(158, 54);
            btn_produtos.TabIndex = 1;
            btn_produtos.Text = "Produtos";
            btn_produtos.UseVisualStyleBackColor = true;
            btn_produtos.Click += btn_produtos_Click;
            // 
            // btn_Dashbord
            // 
            btn_Dashbord.Location = new Point(6, 234);
            btn_Dashbord.Name = "btn_Dashbord";
            btn_Dashbord.Size = new Size(158, 54);
            btn_Dashbord.TabIndex = 0;
            btn_Dashbord.Text = "DashBoard";
            btn_Dashbord.UseVisualStyleBackColor = true;
            btn_Dashbord.Click += btn_Dashbord_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, nome, categoria, Preço, Quantidade, Descricao });
            dataGridView1.Location = new Point(213, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 499);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(728, 61);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(256, 53);
            btn_adicionar.TabIndex = 2;
            btn_adicionar.Text = "Adicionar Produto";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // txt_Pesquisar
            // 
            txt_Pesquisar.Location = new Point(222, 84);
            txt_Pesquisar.Name = "txt_Pesquisar";
            txt_Pesquisar.Size = new Size(190, 27);
            txt_Pesquisar.TabIndex = 3;
            // 
            // lbl_menuAdm
            // 
            lbl_menuAdm.AutoSize = true;
            lbl_menuAdm.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_menuAdm.Location = new Point(222, 18);
            lbl_menuAdm.Name = "lbl_menuAdm";
            lbl_menuAdm.Size = new Size(317, 43);
            lbl_menuAdm.TabIndex = 4;
            lbl_menuAdm.Text = "MENU GERENCIAR";
            // 
            // Id
            // 
            Id.DataPropertyName = "ID_PRODUTO";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // nome
            // 
            nome.DataPropertyName = "NOME_PROD";
            nome.HeaderText = "NOME";
            nome.MinimumWidth = 6;
            nome.Name = "nome";
            nome.Width = 125;
            // 
            // categoria
            // 
            categoria.DataPropertyName = "CATEGORIA";
            categoria.HeaderText = "CATEGORIA";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.Width = 125;
            // 
            // Preço
            // 
            Preço.DataPropertyName = "PRECO";
            Preço.HeaderText = "PREÇO";
            Preço.MinimumWidth = 6;
            Preço.Name = "Preço";
            Preço.Width = 125;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "QUANTIDADE";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 125;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "DESC_PRODUTO";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.Width = 125;
            // 
            // w_MenuAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 649);
            Controls.Add(lbl_menuAdm);
            Controls.Add(txt_Pesquisar);
            Controls.Add(btn_adicionar);
            Controls.Add(dataGridView1);
            Controls.Add(panelMenuAdm);
            Name = "w_MenuAdm";
            Text = "MenuAdm";
            Load += w_MenuAdm_Load;
            panelMenuAdm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenuAdm;
        private DataGridView dataGridView1;
        private Button btn_adicionar;
        private TextBox txt_Pesquisar;
        private Button btn_Dashbord;
        private Button btn_sair;
        private Button btn_relatorio;
        private Button btn_produtos;
        private Label lbl_menuAdm;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Descricao;
    }
}