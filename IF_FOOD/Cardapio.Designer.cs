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
            panelCardapio.Location = new Point(2, 4);
            panelCardapio.Name = "panelCardapio";
            panelCardapio.Size = new Size(166, 695);
            panelCardapio.TabIndex = 0;
            // 
            // btn_Sair
            // 
            btn_Sair.Location = new Point(5, 615);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(158, 54);
            btn_Sair.TabIndex = 4;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // lbl_Cardapio
            // 
            lbl_Cardapio.AutoSize = true;
            lbl_Cardapio.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Cardapio.Location = new Point(238, 85);
            lbl_Cardapio.Name = "lbl_Cardapio";
            lbl_Cardapio.Size = new Size(248, 54);
            lbl_Cardapio.TabIndex = 5;
            lbl_Cardapio.Text = "Cardápio";
            // 
            // txt_Pesquisa
            // 
            txt_Pesquisa.Location = new Point(841, 110);
            txt_Pesquisa.Name = "txt_Pesquisa";
            txt_Pesquisa.Size = new Size(237, 27);
            txt_Pesquisa.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(211, 185);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(938, 428);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // w_cardapio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1182, 697);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txt_Pesquisa);
            Controls.Add(lbl_Cardapio);
            Controls.Add(panelCardapio);
            Name = "w_cardapio";
            Text = "Cardapio";
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