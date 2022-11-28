namespace gyumolcsoktobbform
{
    partial class gyumolcsok_del
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nevtxt = new System.Windows.Forms.TextBox();
            this.mennyisegnum = new System.Windows.Forms.NumericUpDown();
            this.egysegnum = new System.Windows.Forms.NumericUpDown();
            this.gyumolcsok = new System.Windows.Forms.ListBox();
            this.deletebut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egysegnum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(318, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gyumolcsok Torlese";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(241, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(241, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nev";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(241, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mennyiseg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(241, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "EgysegAr";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(314, 120);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(67, 20);
            this.idtxt.TabIndex = 5;
            // 
            // nevtxt
            // 
            this.nevtxt.Location = new System.Drawing.Point(314, 169);
            this.nevtxt.Name = "nevtxt";
            this.nevtxt.Size = new System.Drawing.Size(131, 20);
            this.nevtxt.TabIndex = 6;
            // 
            // mennyisegnum
            // 
            this.mennyisegnum.Location = new System.Drawing.Point(365, 219);
            this.mennyisegnum.Name = "mennyisegnum";
            this.mennyisegnum.Size = new System.Drawing.Size(80, 20);
            this.mennyisegnum.TabIndex = 7;
            this.mennyisegnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // egysegnum
            // 
            this.egysegnum.DecimalPlaces = 2;
            this.egysegnum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.egysegnum.Location = new System.Drawing.Point(360, 262);
            this.egysegnum.Name = "egysegnum";
            this.egysegnum.Size = new System.Drawing.Size(85, 20);
            this.egysegnum.TabIndex = 8;
            this.egysegnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gyumolcsok
            // 
            this.gyumolcsok.FormattingEnabled = true;
            this.gyumolcsok.Location = new System.Drawing.Point(25, 90);
            this.gyumolcsok.Name = "gyumolcsok";
            this.gyumolcsok.Size = new System.Drawing.Size(164, 238);
            this.gyumolcsok.TabIndex = 9;
            // 
            // deletebut
            // 
            this.deletebut.Location = new System.Drawing.Point(345, 312);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(100, 42);
            this.deletebut.TabIndex = 10;
            this.deletebut.Text = "Törlés";
            this.deletebut.UseVisualStyleBackColor = true;
            // 
            // gyumolcsok_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.gyumolcsok);
            this.Controls.Add(this.egysegnum);
            this.Controls.Add(this.mennyisegnum);
            this.Controls.Add(this.nevtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gyumolcsok_del";
            this.Text = "Gyumolcs torlese";
            this.Load += new System.EventHandler(this.gyumolcsok_del_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egysegnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox idtxt;
        public System.Windows.Forms.TextBox nevtxt;
        public System.Windows.Forms.NumericUpDown mennyisegnum;
        public System.Windows.Forms.NumericUpDown egysegnum;
        public System.Windows.Forms.ListBox gyumolcsok;
        private System.Windows.Forms.Button deletebut;
    }
}