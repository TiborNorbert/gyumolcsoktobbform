using MySql.Data.MySqlClient;
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
    public partial class gyumolcsok_upd : Form
    {
        adatbazis Adatbazis = new adatbazis();
        MySqlConnection conn;
        MySqlCommand sqlCommand;
        public gyumolcsok_upd()
        {
            InitializeComponent();
        }

        private void gyumolcsok_upd_Load(object sender, EventArgs e)
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
