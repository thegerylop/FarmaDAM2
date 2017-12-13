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
        string connString;
        MySqlConnection conn;

        public void connexioBD(string comanda)
        {
            connString = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=12345aA;";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                MySqlCommand command = new MySqlCommand(comanda,conn);
                MySqlDataReader dataReader = command.ExecuteReader();
                MessageBox.Show("Success");                
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    } 
}
