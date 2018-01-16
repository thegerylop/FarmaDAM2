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
        string config = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=12345aA;";
        MySqlConnection connexio = new MySqlConnection();
        public Laboratoris()
        {
            InitializeComponent();
        }
        private void Laboratoris_Load(object sender, EventArgs e)
        {
            string select = " * ";
            string table = " laboratoris_farmaceutics";
            string config = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=12345aA;";
            string query = "SELECT"+ select +"FROM" + table;

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
            Laboratoris_Load(sender, e);
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

        private void SubmitLab(object sender, EventArgs e)
        {
            string Codi = CustomCodi.textBox1.Text;
            string Den = CustomDen.textBox1.Text;
            string Soc = CustomSocial.textBox1.Text;
            string CIF = CustomCIF.textBox1.Text;

            string table = "laboratoris_farmaceutics";
            string query = "UPDATE " + table + " SET codi_lab = " + Den + " ,rao_social = " + Soc + " ,cif = " + CIF + " WHERE id_lab = " + Codi;
            connexio.ConnectionString = config;
            try
            {
                MySqlCommand command = new MySqlCommand(query, connexio);
                MySqlDataReader MyReader2;
                connexio.Open();
                MyReader2 = command.ExecuteReader();
                MessageBox.Show("Data Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connexio.Close();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnInserir.Visible = false;
            BtnAceptar.Visible = true;
            dataGridView1.Visible = true;
            BtnAct.Visible = true;
            BtnEliminar.Visible = true;
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnInserir.Visible = true;
            BtnAceptar.Visible = false;
            dataGridView1.Visible = false;
            BtnAct.Visible = false;
            BtnEliminar.Visible = false;
        }
    }
}
