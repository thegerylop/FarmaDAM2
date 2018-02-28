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
        string connString = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=diopters12345;";
        MySqlConnection conn = new MySqlConnection();

        public string connexioLogin(String login, String password)
        {
            string comanda = "SELECT usuari, contrasenya FROM personal WHERE BINARY usuari = '" + login + "' and contrasenya = '" + password + "'";
            conn.ConnectionString = connString;
            conn.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(comanda, conn);
                MySqlDataReader dataReader = command.ExecuteReader();
                string select = null;
                //code to get select
                if (dataReader.Read())
                {
                    dataReader.Read();
                    if (dataReader[0].ToString().Length > 1 && dataReader[1].ToString().Length > 1)
                    {
                        select = dataReader[0].ToString() + " - " + dataReader[1].ToString();
                    }
                    dataReader.Close();
                    return select;
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }

        public void connexio()
        {
            conn = new MySqlConnection(connString);
            conn.Open();
            conn.InitializeLifetimeService();
        }
        public DataSet portarPerConsulta(String query, String table)
        {
            MySqlDataAdapter dtaDades = new MySqlDataAdapter();
            MySqlCommandBuilder construct = new MySqlCommandBuilder();
            DataSet dtsDades = new DataSet();

            try
            {
                connexio();
                dtaDades = new MySqlDataAdapter(query, conn);
                construct = new MySqlCommandBuilder(dtaDades);
                dtsDades = new DataSet();
                dtaDades.Fill(dtsDades, table);


            }
            catch (MySqlException eMySql)
            {
                MessageBox.Show(eMySql.ToString());
            }
            finally
            {
                if (conn != null)
                {
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

                dtaDepart = new MySqlDataAdapter(query, conn);
                construct = new MySqlCommandBuilder(dtaDepart);

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
                if (conn != null)
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

        public DataTable searchTableFromQuery(string query2)
        {
            MySqlDataAdapter dtaDades = new MySqlDataAdapter();
            MySqlCommandBuilder construct = new MySqlCommandBuilder();
            DataSet dtsDades = new DataSet();
            DataTable dt = null;
            try
            {
                connexio();
                dtaDades = new MySqlDataAdapter(query2, conn);
                construct = new MySqlCommandBuilder(dtaDades);
                dtsDades = new DataSet();
                dt = new DataTable();
                dtaDades.Fill(dt);


            }
            catch (MySqlException eMySql)
            {
                MessageBox.Show(eMySql.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return dt;
        }
        public Boolean executaComanda(string comanda)
        {
            try
            {
                connexio();
                MySqlCommand command = new MySqlCommand(comanda, conn);
                var result = command.ExecuteScalar();
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException eMySql)
            {
                MessageBox.Show(eMySql.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}