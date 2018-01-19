using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace ConexioBBDD
{
    public class Conexio
    {
        string connString = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=12345aA;";
        MySqlConnection conn = new MySqlConnection();

        public void connexio()
        {
            conn = new MySqlConnection(connString);
            conn.Open();
            conn.InitializeLifetimeService();
        }
        public DataSet portarPerConsulta(String query) {
            MySqlDataAdapter dtaDades = new MySqlDataAdapter();
            MySqlCommandBuilder construct = new MySqlCommandBuilder();
            DataSet dtsDades = new DataSet();

            try{
                connexio();
                dtaDades = new MySqlDataAdapter(query, conn);
                construct = new MySqlCommandBuilder(dtaDades);
                dtsDades = new DataSet();
                dtaDades.Fill(dtsDades, "laboratoris_farmaceutics");
            } catch (MySqlException eMySql) {
                MessageBox.Show(eMySql.ToString());
            } finally {
                if (conn != null) {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return dtsDades;
        }
        public bool Actualitzar(String query, String taula, DataSet dtsAct)
        {
            bool correcte = true;

            MySqlDataAdapter dtaDepart;
            MySqlCommandBuilder construct;

            try
            {
                connexio();

                dtaDepart = new MySqlDataAdapter();
                construct = new MySqlCommandBuilder();

                if (dtsAct.HasChanges())
                {
                    dtaDepart.Update(dtsAct, taula);
                }
            }
            catch (MySqlException e)
            {
                correcte = false;
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return correcte;
        }

        public int executaSQL(String cmd)
        {
            connexio();

            MySqlCommand cmdQry = new MySqlCommand(cmd, conn);

            return cmdQry.ExecuteNonQuery();
        }
    }
}