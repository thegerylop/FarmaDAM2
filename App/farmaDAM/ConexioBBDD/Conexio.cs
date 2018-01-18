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

        public string connexioLogin(String login, String password){
            string comanda = "SELECT usuari, contrasenya FROM personal WHERE usuari = '" + login + "' and contrasenya = '" + password + "'";
            conn.ConnectionString = connString;
            conn.Open();
             try { 
                MySqlCommand command = new MySqlCommand(comanda, conn);
                MySqlDataReader dataReader = command.ExecuteReader();
                string select = null;
                //code to get select
                dataReader.Read();
                if (dataReader[0].ToString().Length > 1 && dataReader[1].ToString().Length > 1){
                    select = dataReader[0].ToString() + " - " + dataReader[1].ToString();}
                dataReader.Close();
                return select;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }

        public bool inserir(string comanda){
            conn.ConnectionString = connString;
            conn.Open();
            try{
                MySqlCommand command = new MySqlCommand(comanda, conn);
                var resultSet = command.ExecuteNonQuery();
                if (resultSet.Equals(1)) { return true; }
                else { return false; }
            }catch (MySql.Data.MySqlClient.MySqlException mysqlex){
                MessageBox.Show(mysqlex.Message);
                return false;
            }finally { conn.Close(); }
        }

        public bool delete(string comanda)
        {
            conn.ConnectionString = connString;
            conn.Open();
            MySqlCommand command = new MySqlCommand(comanda, conn);
            var resultSet = command.ExecuteNonQuery();
            if (resultSet.Equals(1)) { conn.Close(); return true;}
            else { conn.Close(); return false;}
             
        }

        public DataTable filltable(string comanda){
            conn.ConnectionString = connString;
            conn.Open();
            DataTable data = new DataTable();
            try{
                MySqlCommand command = new MySqlCommand(comanda, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(data);
                return data;}
            catch (MySql.Data.MySqlClient.MySqlException mysqlex){
                MessageBox.Show(mysqlex.Message);
                return data;}
            finally { conn.Close(); }
        }

        public bool update_field(string comanda)
        {
            conn.ConnectionString = connString;
            conn.Open();
            MySqlDataReader MyReader2;

            try{
                MySqlCommand command = new MySqlCommand(comanda, conn);               
                MyReader2 = command.ExecuteReader();
                return true;
            }catch (MySql.Data.MySqlClient.MySqlException mysqlex){
                MessageBox.Show(mysqlex.Message);
                return false;
            }
            finally { conn.Close(); }
        }
    }
}