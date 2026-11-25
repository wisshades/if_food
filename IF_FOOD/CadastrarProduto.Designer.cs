namespace IF_FOOD
{
    partial class w_CadastrarProduto
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
            panelImagem = new Panel();
            lbl_imagem = new Label();
            pb_cad = new PictureBox();
            panelCadastrar = new Panel();
            txt_qnt = new TextBox();
            lbl_qnt = new Label();
            txt_desc = new TextBox();
            lbl_desc = new Label();
            txt_preco = new TextBox();
            lbl_preco = new Label();
            cb_categoria = new ComboBox();
            lbl_categoria = new Label();
            txt_nome = new TextBox();
            lbl_nome = new Label();
            btn_salvar = new Button();
            lbl_cadastro = new Label();
            btn_fechar = new Button();
            panelImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_cad).BeginInit();
            panelCadastrar.SuspendLayout();
            SuspendLayout();
            // 
            // panelImagem
            // 
            panelImagem.BackColor = Color.FromArgb(64, 0, 64);
            panelImagem.Controls.Add(lbl_imagem);
            panelImagem.Controls.Add(pb_cad);
            panelImagem.Location = new Point(62, 89);
            panelImagem.Name = "panelImagem";
            panelImagem.Size = new Size(254, 321);
            panelImagem.TabIndex = 0;
            // 
            // lbl_imagem
            // 
            lbl_imagem.AutoSize = true;
            lbl_imagem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_imagem.ForeColor = SystemColors.ButtonHighlight;
            lbl_imagem.Location = new Point(44, 27);
            lbl_imagem.Name = "lbl_imagem";
            lbl_imagem.Size = new Size(172, 23);
            lbl_imagem.TabIndex = 1;
            lbl_imagem.Text = "Imagem do Produto";
            // 
            // pb_cad
            // 
            pb_cad.BackColor = Color.White;
            pb_cad.Location = new Point(25, 110);
            pb_cad.Name = "pb_cad";
            pb_cad.Size = new Size(204, 179);
            pb_cad.TabIndex = 0;
            pb_cad.TabStop = false;
            pb_cad.Click += pb_cad_Click;
            // 
            // panelCadastrar
            // 
            panelCadastrar.BackColor = Color.FromArgb(64, 0, 64);
            panelCadastrar.Controls.Add(txt_qnt);
            panelCadastrar.Controls.Add(lbl_qnt);
            panelCadastrar.Controls.Add(txt_desc);
            panelCadastrar.Controls.Add(lbl_desc);
            panelCadastrar.Controls.Add(txt_preco);
            panelCadastrar.Controls.Add(lbl_preco);
            panelCadastrar.Controls.Add(cb_categoria);
            panelCadastrar.Controls.Add(lbl_categoria);
            panelCadastrar.Controls.Add(txt_nome);
            panelCadastrar.Controls.Add(lbl_nome);
            panelCadastrar.Location = new Point(391, 89);
            panelCadastrar.Name = "panelCadastrar";
            panelCadastrar.Size = new Size(344, 432);
            panelCadastrar.TabIndex = 1;
            // 
            // txt_qnt
            // 
            txt_qnt.Location = new Point(18, 376);
            txt_qnt.Name = "txt_qnt";
            txt_qnt.Size = new Size(298, 27);
            txt_qnt.TabIndex = 9;
            // 
            // lbl_qnt
            // 
            lbl_qnt.AutoSize = true;
            lbl_qnt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_qnt.ForeColor = SystemColors.ButtonHighlight;
            lbl_qnt.Location = new Point(18, 353);
            lbl_qnt.Name = "lbl_qnt";
            lbl_qnt.Size = new Size(104, 23);
            lbl_qnt.TabIndex = 8;
            lbl_qnt.Text = "Quantidade";
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(18, 301);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(298, 27);
            txt_desc.TabIndex = 7;
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_desc.ForeColor = SystemColors.ButtonHighlight;
            lbl_desc.Location = new Point(18, 278);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(86, 23);
            lbl_desc.TabIndex = 6;
            lbl_desc.Text = "Descrição";
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(18, 219);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(298, 27);
            txt_preco.TabIndex = 5;
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_preco.ForeColor = SystemColors.ButtonHighlight;
            lbl_preco.Location = new Point(18, 187);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(54, 23);
            lbl_preco.TabIndex = 4;
            lbl_preco.Text = "Preço";
            // 
            // cb_categoria
            // 
            cb_categoria.FormattingEnabled = true;
            cb_categoria.Items.AddRange(new object[] { "Wrap", "Bebida", "Sobremesa" });
            cb_categoria.Location = new Point(18, 121);
            cb_categoria.Name = "cb_categoria";
            cb_categoria.Size = new Size(298, 28);
            cb_categoria.TabIndex = 3;
            cb_categoria.SelectedIndexChanged += cb_categoria_SelectedIndexChanged;
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_categoria.ForeColor = SystemColors.ButtonHighlight;
            lbl_categoria.Location = new Point(18, 88);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(88, 23);
            lbl_categoria.TabIndex = 2;
            lbl_categoria.Text = "Categoria";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(18, 36);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(298, 27);
            txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = SystemColors.ButtonHighlight;
            lbl_nome.Location = new Point(18, 7);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(154, 23);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome do Produto";
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(229, 556);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(292, 47);
            btn_salvar.TabIndex = 2;
            btn_salvar.Text = "Salvar Produto";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_cadastro.Location = new Point(68, 9);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(547, 54);
            lbl_cadastro.TabIndex = 6;
            lbl_cadastro.Text = "Cadastro De Produto";
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(630, 549);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(158, 54);
            btn_fechar.TabIndex = 7;
            btn_fechar.Text = "Sair";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // w_CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 631);
            Controls.Add(btn_fechar);
            Controls.Add(lbl_cadastro);
            Controls.Add(btn_salvar);
            Controls.Add(panelCadastrar);
            Controls.Add(panelImagem);
            Name = "w_CadastrarProduto";
            Text = "CadastrarProduto";
            Load += w_CadastrarProduto_Load;
            panelImagem.ResumeLayout(false);
            panelImagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_cad).EndInit();
            panelCadastrar.ResumeLayout(false);
            panelCadastrar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelImagem;
        private PictureBox pb_cad;
        private Panel panelCadastrar;
        private TextBox txt_desc;
        private Label lbl_desc;
        private TextBox txt_preco;
        private Label lbl_preco;
        private ComboBox cb_categoria;
        private Label lbl_categoria;
        private TextBox txt_nome;
        private Label lbl_nome;
        private Button btn_salvar;
        private TextBox txt_qnt;
        private Label lbl_qnt;
        private Label lbl_imagem;
        private Label lbl_cadastro;
        private Button btn_fechar;
    }
}