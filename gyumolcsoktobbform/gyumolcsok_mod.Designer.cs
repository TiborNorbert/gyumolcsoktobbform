namespace gyumolcsoktobbform
{
    partial class gyumolcsok_mod
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gyumolcsok = new System.Windows.Forms.ListBox();
            this.IDtxt = new System.Windows.Forms.MaskedTextBox();
            this.nevtxt = new System.Windows.Forms.TextBox();
            this.egysegnum = new System.Windows.Forms.NumericUpDown();
            this.mennyisegnum = new System.Windows.Forms.NumericUpDown();
            this.Hozzaadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.egysegnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(308, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gyumolcs Hozzaadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(241, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nev.Location = new System.Drawing.Point(241, 176);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(42, 22);
            this.nev.TabIndex = 2;
            this.nev.Text = "Nev";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(241, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "EgysegAr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(241, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mennyiseg";
            // 
            // gyumolcsok
            // 
            this.gyumolcsok.FormattingEnabled = true;
            this.gyumolcsok.Location = new System.Drawing.Point(30, 120);
            this.gyumolcsok.Name = "gyumolcsok";
            this.gyumolcsok.Size = new System.Drawing.Size(142, 186);
            this.gyumolcsok.TabIndex = 5;
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(297, 141);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.ReadOnly = true;
            this.IDtxt.Size = new System.Drawing.Size(100, 20);
            this.IDtxt.TabIndex = 6;
            // 
            // nevtxt
            // 
            this.nevtxt.Location = new System.Drawing.Point(297, 176);
            this.nevtxt.Name = "nevtxt";
            this.nevtxt.Size = new System.Drawing.Size(125, 20);
            this.nevtxt.TabIndex = 7;
            // 
            // egysegnum
            // 
            this.egysegnum.Location = new System.Drawing.Point(355, 206);
            this.egysegnum.Name = "egysegnum";
            this.egysegnum.Size = new System.Drawing.Size(114, 20);
            this.egysegnum.TabIndex = 8;
            // 
            // mennyisegnum
            // 
            this.mennyisegnum.Location = new System.Drawing.Point(354, 246);
            this.mennyisegnum.Name = "mennyisegnum";
            this.mennyisegnum.Size = new System.Drawing.Size(114, 20);
            this.mennyisegnum.TabIndex = 9;
            // 
            // Hozzaadas
            // 
            this.Hozzaadas.Location = new System.Drawing.Point(342, 306);
            this.Hozzaadas.Name = "Hozzaadas";
            this.Hozzaadas.Size = new System.Drawing.Size(126, 50);
            this.Hozzaadas.TabIndex = 10;
            this.Hozzaadas.Text = "hozzaadas";
            this.Hozzaadas.UseVisualStyleBackColor = true;
            this.Hozzaadas.Click += new System.EventHandler(this.Hozzaadas_Click);
            // 
            // gyumolcsok_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hozzaadas);
            this.Controls.Add(this.mennyisegnum);
            this.Controls.Add(this.egysegnum);
            this.Controls.Add(this.nevtxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.gyumolcsok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gyumolcsok_mod";
            this.Text = "Gyumolcsok hozzaadasa";
            this.Load += new System.EventHandler(this.gyumolcsok_mod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.egysegnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox gyumolcsok;
        private System.Windows.Forms.MaskedTextBox IDtxt;
        private System.Windows.Forms.TextBox nevtxt;
        private System.Windows.Forms.NumericUpDown egysegnum;
        private System.Windows.Forms.NumericUpDown mennyisegnum;
        private System.Windows.Forms.Button Hozzaadas;
    }
}