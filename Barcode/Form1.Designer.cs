namespace Barcode
{
    partial class Form1
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
            bc_tb = new TextBox();
            l_kod = new Label();
            l_pers = new Label();
            l_cmim = new Label();
            Oferte = new Label();
            barcod = new Label();
            SkanoBc = new Label();
            label1 = new Label();
            njesi = new Label();
            SuspendLayout();
            // 
            // bc_tb
            // 
            bc_tb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bc_tb.Location = new Point(118, 60);
            bc_tb.Margin = new Padding(3, 2, 3, 2);
            bc_tb.Name = "bc_tb";
            bc_tb.Size = new Size(1145, 39);
            bc_tb.TabIndex = 0;
            bc_tb.TextChanged += bc_tb_TextChanged;
            bc_tb.KeyDown += bc_tb_KeyDown;
            // 
            // l_kod
            // 
            l_kod.AutoSize = true;
            l_kod.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            l_kod.ForeColor = SystemColors.Desktop;
            l_kod.Location = new Point(331, 101);
            l_kod.Name = "l_kod";
            l_kod.Size = new Size(100, 37);
            l_kod.TabIndex = 1;
            l_kod.Text = "label1";
            l_kod.Visible = false;
            l_kod.Click += l_kod_Click;
            // 
            // l_pers
            // 
            l_pers.Font = new Font("Microsoft Sans Serif", 56.25F, FontStyle.Regular, GraphicsUnit.Point);
            l_pers.ForeColor = SystemColors.Highlight;
            l_pers.Location = new Point(12, 136);
            l_pers.Name = "l_pers";
            l_pers.Size = new Size(1424, 281);
            l_pers.TabIndex = 2;
            l_pers.Text = "label2";
            l_pers.Visible = false;
            l_pers.Click += l_pers_Click;
            // 
            // l_cmim
            // 
            l_cmim.AutoSize = true;
            l_cmim.Font = new Font("Microsoft JhengHei", 92.25F, FontStyle.Bold, GraphicsUnit.Point);
            l_cmim.ForeColor = Color.Black;
            l_cmim.Location = new Point(671, 515);
            l_cmim.Name = "l_cmim";
            l_cmim.Size = new Size(425, 155);
            l_cmim.TabIndex = 3;
            l_cmim.Text = "label3";
            l_cmim.TextAlign = ContentAlignment.BottomRight;
            l_cmim.Visible = false;
            l_cmim.Click += l_cmim_Click;
            // 
            // Oferte
            // 
            Oferte.AutoSize = true;
            Oferte.Font = new Font("Cooper Black", 72F, FontStyle.Regular, GraphicsUnit.Point);
            Oferte.ForeColor = Color.Red;
            Oferte.Location = new Point(655, 405);
            Oferte.Name = "Oferte";
            Oferte.Size = new Size(390, 110);
            Oferte.TabIndex = 5;
            Oferte.Text = "Oferte!";
            Oferte.Visible = false;
            Oferte.Click += Oferte_Click;
            // 
            // barcod
            // 
            barcod.AutoSize = true;
            barcod.Location = new Point(92, 441);
            barcod.Name = "barcod";
            barcod.Size = new Size(38, 15);
            barcod.TabIndex = 6;
            barcod.Text = "label1";
            barcod.Visible = false;
            // 
            // SkanoBc
            // 
            SkanoBc.AutoSize = true;
            SkanoBc.BackColor = Color.Transparent;
            SkanoBc.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            SkanoBc.ForeColor = SystemColors.Highlight;
            SkanoBc.Location = new Point(1269, 60);
            SkanoBc.Name = "SkanoBc";
            SkanoBc.Size = new Size(54, 40);
            SkanoBc.TabIndex = 7;
            SkanoBc.Text = "BC";
            SkanoBc.Click += SkanoBc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(576, 9);
            label1.Name = "label1";
            label1.Size = new Size(350, 42);
            label1.TabIndex = 8;
            label1.Text = "Skano Artikullin!";
            label1.Click += label1_Click;
            // 
            // njesi
            // 
            njesi.AutoSize = true;
            njesi.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point);
            njesi.ForeColor = SystemColors.Desktop;
            njesi.Location = new Point(1124, 578);
            njesi.Name = "njesi";
            njesi.Size = new Size(164, 73);
            njesi.TabIndex = 9;
            njesi.Text = "njesi";
            njesi.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1448, 725);
            Controls.Add(njesi);
            Controls.Add(label1);
            Controls.Add(SkanoBc);
            Controls.Add(barcod);
            Controls.Add(Oferte);
            Controls.Add(l_cmim);
            Controls.Add(l_pers);
            Controls.Add(l_kod);
            Controls.Add(bc_tb);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Skano Bc";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox bc_tb;
        public Label l_kod;
        public Label l_pers;
        public Label l_cmim;
        private Label Oferte;
        private Label barcod;
        private Label SkanoBc;
        private Label label1;
        public Label njesi;
    }
}