namespace gyumolcsoktobbform
{
    partial class Gyumolcsok_nyit
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újGyümölcsFelvételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyümölcsModositasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyümölcsTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.egysegnum = new System.Windows.Forms.NumericUpDown();
            this.mennyisegnum = new System.Windows.Forms.NumericUpDown();
            this.gyumolcsok = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.egysegnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újGyümölcsFelvételToolStripMenuItem,
            this.gyümölcsModositasToolStripMenuItem,
            this.gyümölcsTörléseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 426);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újGyümölcsFelvételToolStripMenuItem
            // 
            this.újGyümölcsFelvételToolStripMenuItem.Name = "újGyümölcsFelvételToolStripMenuItem";
            this.újGyümölcsFelvételToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.újGyümölcsFelvételToolStripMenuItem.Text = "Új gyümölcs felvétel";
            this.újGyümölcsFelvételToolStripMenuItem.Click += new System.EventHandler(this.újGyümölcsFelvételToolStripMenuItem_Click);
            // 
            // gyümölcsModositasToolStripMenuItem
            // 
            this.gyümölcsModositasToolStripMenuItem.Name = "gyümölcsModositasToolStripMenuItem";
            this.gyümölcsModositasToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.gyümölcsModositasToolStripMenuItem.Text = "gyümölcs modositas";
            this.gyümölcsModositasToolStripMenuItem.Click += new System.EventHandler(this.gyümölcsModositasToolStripMenuItem_Click);
            // 
            // gyümölcsTörléseToolStripMenuItem
            // 
            this.gyümölcsTörléseToolStripMenuItem.Name = "gyümölcsTörléseToolStripMenuItem";
            this.gyümölcsTörléseToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gyümölcsTörléseToolStripMenuItem.Text = "gyümölcs törlése";
            this.gyümölcsTörléseToolStripMenuItem.Click += new System.EventHandler(this.gyümölcsTörléseToolStripMenuItem_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ID.Location = new System.Drawing.Point(363, 122);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(28, 22);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(340, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(251, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gyümölcs nyilvántartás";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(308, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Egységár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(294, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mennyiseg";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(421, 125);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.ReadOnly = true;
            this.IDtxt.Size = new System.Drawing.Size(66, 20);
            this.IDtxt.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 7;
            // 
            // egysegnum
            // 
            this.egysegnum.DecimalPlaces = 2;
            this.egysegnum.Location = new System.Drawing.Point(421, 214);
            this.egysegnum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.egysegnum.Name = "egysegnum";
            this.egysegnum.Size = new System.Drawing.Size(120, 20);
            this.egysegnum.TabIndex = 8;
            this.egysegnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mennyisegnum
            // 
            this.mennyisegnum.Location = new System.Drawing.Point(421, 261);
            this.mennyisegnum.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.mennyisegnum.Name = "mennyisegnum";
            this.mennyisegnum.Size = new System.Drawing.Size(120, 20);
            this.mennyisegnum.TabIndex = 9;
            this.mennyisegnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gyumolcsok
            // 
            this.gyumolcsok.FormattingEnabled = true;
            this.gyumolcsok.Location = new System.Drawing.Point(12, 122);
            this.gyumolcsok.Name = "gyumolcsok";
            this.gyumolcsok.Size = new System.Drawing.Size(194, 225);
            this.gyumolcsok.TabIndex = 10;
            // 
            // Gyumolcsok_nyit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gyumolcsok);
            this.Controls.Add(this.mennyisegnum);
            this.Controls.Add(this.egysegnum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gyumolcsok_nyit";
            this.Text = "Gyumolcsok";
            this.Load += new System.EventHandler(this.Gyumolcsok_nyit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.egysegnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újGyümölcsFelvételToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyümölcsModositasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyümölcsTörléseToolStripMenuItem;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.NumericUpDown egysegnum;
        public System.Windows.Forms.NumericUpDown mennyisegnum;
        private System.Windows.Forms.ListBox gyumolcsok;
    }
}

