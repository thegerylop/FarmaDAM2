using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ConexioBBDD
{
    public class Conexio
    {
        string connString = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=12345aA;";
        MySqlConnection conn = new MySqlConnection();
        
        public string connexioLogin(String login, String password)
        {
            string comanda = "SELECT usuari, contrasenya FROM personal WHERE usuari = '" + login + "' and contrasenya = '" + password + "'";
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                MySqlCommand command = new MySqlCommand(comanda, conn);
                MySqlDataReader dataReader = command.ExecuteReader();
                string select = null;

                //code to get select
                dataReader.Read();

                if (dataReader[0].ToString().Length > 1 && dataReader[1].ToString().Length > 1)
                {
                    select = dataReader[0].ToString() + " - " + dataReader[1].ToString();
                }

                dataReader.Close();
                conn.Close();
                return select;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
