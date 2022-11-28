using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyumolcsoktobbform
{
    public partial class Gyumolcsok_nyit : Form
    {
        adatbazis Adatbazis = new adatbazis();
       
        public Gyumolcsok_nyit()
        {
            InitializeComponent();
        }

        private void Gyumolcsok_nyit_Load(object sender, EventArgs e)
        {
            gyumolcsokbetoltese();
        }
        private void gyumolcsokbetoltese()
        {
            gyumolcsok.Items.Clear();
            foreach (gyumolcs item in Adatbazis.getAllGyumolcs())
            {
                gyumolcsok.Items.Add(item);
            }
        }

        private void újGyümölcsFelvételToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.gyumolcsok_Mod.ShowDialog();
        }

        private void gyümölcsTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.gyumolcsok_Del.ShowDialog();
        }

        private void gyümölcsModositasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.gyumolcsok_Upd.ShowDialog();
            
        }
    }
}
