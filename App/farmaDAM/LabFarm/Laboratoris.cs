using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LabFarm
{
    public partial class Laboratoris : Form
    {
        public Laboratoris()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Laboratoris_Load(object sender, EventArgs e)
        {
            string config = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=12345aA;";
            string query = "SELECT * FROM laboratoris_farmaceutics";

            MySqlConnection connexio = new MySqlConnection();
            connexio.ConnectionString = config;
            connexio.Open();

            MySqlCommand command = new MySqlCommand(query, connexio);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            connexio.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string config = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=12345aA;";
            string query = "SELECT * FROM laboratoris_farmaceutics";

            MySqlConnection connexio = new MySqlConnection();
            connexio.ConnectionString = config;
            connexio.Open();

            MySqlCommand command = new MySqlCommand(query, connexio);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            connexio.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                CustomCodi.textBox1.Text = row.Cells[0].Value.ToString();
                CustomDen.textBox1.Text = row.Cells[1].Value.ToString();
                CustomSocial.textBox1.Text = row.Cells[2].Value.ToString();
                CustomCIF.textBox1.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
