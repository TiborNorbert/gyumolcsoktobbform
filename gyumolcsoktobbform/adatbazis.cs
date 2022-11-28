using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gyumolcsoktobbform
{
    internal class adatbazis
    {
        MySqlConnection conn;
        MySqlCommand sqlCommand;
        string hibaszoveg = null;

        public adatbazis(string server = "localhost", string user = "root", string password = "", string database = "gyumolcsok")
        {
            conn = new MySqlConnection(kapcsolatstring(server, user, password, database));
            if (kapcsolatnyit())
            {
                sqlCommand = conn.CreateCommand();
            }
            else
            {
                MessageBox.Show(hibaszoveg);
                hibaszoveg = null;
            }
        }
        public List<gyumolcs> getAllGyumolcs()
        {
            List<gyumolcs> list = new List<gyumolcs>();
            sqlCommand.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcsok` WHERE 1";
            if (kapcsolatnyit())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        gyumolcs gyumolcs = new gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                        list.Add(gyumolcs);
                    }
                }
                kapcsolatzar();
            }
            return list;
        }

        private bool kapcsolatnyit()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();

                }
            }
            catch (MySqlException ex)
            {
                hibaszoveg = ex.Message;
                return false;
            }
            return true;
        }
        private bool kapcsolatzar()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();

                }
            }
            catch (MySqlException ex)
            {
                hibaszoveg = ex.Message;
                return false;
            }
            return true;
        }

        private string kapcsolatstring(string server, string user, string password, string database)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = database;
            return builder.ConnectionString;
        }
    }
}
