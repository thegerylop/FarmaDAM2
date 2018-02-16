using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConexioBBDD;
namespace Ventas
{
    public partial class Ventas : Form
    {
        string table = "clients";
        string query;
        string comboBoxQuery;
        DataSet dataSet = new DataSet();
        DataSet medicaments = new DataSet();
        string connString = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=diopters12345;";
        MySqlConnection conn = new MySqlConnection();
        ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

            groupBoxMed.Visible = false;
            groupBoxLlista.Visible = false;
            CcomboBox.SelectedIndex = 0;
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query, table);
            medicaments = bd.portarPerConsulta("select * from medicaments", "medicaments");
            BindingDades("medicaments");
            

        }
        private void BindingDades(string table)
        {
            dgvVentas.AutoGenerateColumns = true;
            dgvVentas.DataSource = medicaments.Tables[table]; // dataset
            dgvVentas.Columns[0].Visible = false;
            dgvVentas.Columns[1].Visible = false;
            dgvVentas.Columns[2].Visible = false;
            dgvVentas.Columns[5].Visible = false;
            dgvVentas.Columns[6].Visible = false;
            dgvVentas.Columns[7].Visible = false;
            dgvVentas.Columns[9].Visible = false;
            dgvVentas.Columns[10].Visible = false;
            dgvVentas.Columns[11].Visible = false;
            dgvVentas.Columns[13].Visible = false;
            dgvVentas.Columns[14].Visible = false;
        }

        private void customTextBox1_Leave(object sender, EventArgs e)
        {
            query = "Select " + CcomboBox.Text + " from clients where " + CcomboBox.Text + " = " + customTextBox1.Text;
            dataSet = bd.portarPerConsulta(query, table);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("El client indicat no existeix");
                customTextBox1.Text = "";
            }
            else
            {
                customTextBox1.Enabled = false;
                CcomboBox.Enabled = false;
                groupBoxMed.Visible = true;
                groupBoxLlista.Visible = true;
            }
        }

        private void customTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] row = { "aaa", "aaa", "aaa" };
            var listViewItem = new ListViewItem(row);
            listViewCompra.Items.Add(listViewItem);
        }
    }
}
