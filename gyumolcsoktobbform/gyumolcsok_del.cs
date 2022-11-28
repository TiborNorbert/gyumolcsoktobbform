using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyumolcsoktobbform
{
    public partial class gyumolcsok_del : Form
    {
        adatbazis Adatbazis = new adatbazis();
        public gyumolcsok_del()
        {
            InitializeComponent();
        }

        private void gyumolcsok_del_Load(object sender, EventArgs e)
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
    }
}
