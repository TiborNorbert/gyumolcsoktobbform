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
    public partial class gyumolcsok_mod : Form
    {
        adatbazis Adatbazis = new adatbazis();
        MySqlConnection conn;
        MySqlCommand sqlCommand;
        public gyumolcsok_mod()
        {
            InitializeComponent();
        }

        private void gyumolcsok_mod_Load(object sender, EventArgs e)
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
        private void gyumolcs_update()
        {
            gyumolcsok.Items.Clear();
            sqlCommand.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcs` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = sqlCommand.ExecuteReader())
            {
                while (dr.Read())
                {
                    gyumolcs uj = new gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("Mennyiseg"));
                    gyumolcsok.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void Hozzaadas_Click(object sender, EventArgs e)
        {
            if (egysegnum.Value<0)
            {
                MessageBox.Show("adjon meg egyszégárat");
                egysegnum.Focus();
                return;
            }
            if (mennyisegnum.Value > 1000)
            {
                MessageBox.Show("Érvénytelen évjárat");
                mennyisegnum.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nevtxt.Text))
            {
                MessageBox.Show("Nem adott meg nevet");
                nevtxt.Focus();
                return;
            }
            sqlCommand.CommandText = "INSERT INTO `gyumolcs` (`id`, `nev`, `egysegar`, `mennyiseg`) VALUES (NULL, @nev, @mennyiseg, @egysegar)";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nev", nevtxt.Text);
            sqlCommand.Parameters.AddWithValue("@mennyiseg", mennyisegnum.Value.ToString());
            sqlCommand.Parameters.AddWithValue("@egysegar", egysegnum.Value.ToString());
            conn.Open();
            try
            {
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzitettük az adatait");
                    IDtxt.Text = "";
                    nevtxt.Text = "";
                    mennyisegnum.Value = mennyisegnum.Minimum;
                    egysegnum.Value=egysegnum.Minimum;
                }
                else
                {
                    MessageBox.Show("Sikertelen a rögzités");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            gyumolcs_update();
        }
    }
}
