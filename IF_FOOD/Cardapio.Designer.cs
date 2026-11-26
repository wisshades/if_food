namespace IF_FOOD
{
    partial class w_cardapio
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
            panelCardapio = new Panel();
            btn_Sair = new Button();
            lbl_Cardapio = new Label();
            txt_Pesquisa = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelCardapio.SuspendLayout();
            SuspendLayout();
            // 
            // panelCardapio
            // 
            panelCardapio.BackColor = Color.FromArgb(64, 0, 64);
            panelCardapio.Controls.Add(btn_Sair);
            panelCardapio.Location = new Point(2, 3);
            panelCardapio.Margin = new Padding(3, 2, 3, 2);
            panelCardapio.Name = "panelCardapio";
            panelCardapio.Size = new Size(145, 521);
            panelCardapio.TabIndex = 0;
            // 
            // btn_Sair
            // 
            btn_Sair.Location = new Point(4, 461);
            btn_Sair.Margin = new Padding(3, 2, 3, 2);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(138, 40);
            btn_Sair.TabIndex = 4;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // lbl_Cardapio
            // 
            lbl_Cardapio.AutoSize = true;
            lbl_Cardapio.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Cardapio.Location = new Point(208, 64);
            lbl_Cardapio.Name = "lbl_Cardapio";
            lbl_Cardapio.Size = new Size(165, 39);
            lbl_Cardapio.TabIndex = 5;
            lbl_Cardapio.Text = "Cardápio";
            // 
            // txt_Pesquisa
            // 
            txt_Pesquisa.Location = new Point(736, 82);
            txt_Pesquisa.Margin = new Padding(3, 2, 3, 2);
            txt_Pesquisa.Name = "txt_Pesquisa";
            txt_Pesquisa.Size = new Size(208, 23);
            txt_Pesquisa.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(185, 139);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(821, 321);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // w_cardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1034, 523);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txt_Pesquisa);
            Controls.Add(lbl_Cardapio);
            Controls.Add(panelCardapio);
            Margin = new Padding(3, 2, 3, 2);
            Name = "w_cardapio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cardápio";
            panelCardapio.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCardapio;
        private Label lbl_Cardapio;
        private TextBox txt_Pesquisa;
        private Button btn_Sair;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}