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
namespace Clients
{
    public partial class Clients : Form
    {
        string table = "clients";
        string query;
        string comboBoxQuery;
        DataSet dataSet = new DataSet();
        string connString = "SERVER= 51.255.58.1;PORT=3306;DATABASE=g2s2am_FarmaDAM;UID=g2s2am;PASSWORD=diopters12345;";
        MySqlConnection conn = new MySqlConnection();
        ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            cbClients.SelectedIndex = 0;
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query, table);
            //ComboBox table options
            comboBoxQuery = "Select nom_carnet from " + CcomboBox.Reference;
            DataTable t = bd.searchTableFromQuery(comboBoxQuery);
            addComboBoxData(t ,CcomboBox);

            BindingDades(table);


            clientsDataGridView.Columns[0].Visible = false;
            clientsDataGridView.Columns[7].Visible = false;
        }

        //bindegar dades textbox
        private void BindingDades(string table)
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {
                    if (txt.Tag.ToString() != "")
                    {
                        txt.DataBindings.Clear();
                        txt.DataBindings.Add("Text", dataSet.Tables[table], txt.Tag.ToString(), true);
                        txt.Validated += new System.EventHandler(this.validarText);

                    }
                }
            }

            dataBindingComboBox(dataSet);
            clientsDataGridView.AutoGenerateColumns = true;
            clientsDataGridView.DataSource = dataSet.Tables[table]; // dataset
        }
        private void validarText(object sender, EventArgs e)
        {
            Control test = (Control)sender;
            test.DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
        
        public void addComboBoxData(DataTable t, ComboBox CcomboBox)
        {
            CcomboBox.Items.Add("Selecciona...");
            CcomboBox.SelectedIndex = 0;
            for (var i = 0; i < t.Rows.Count; i++)
            {
                DataRow r = t.Rows[i];
                if (r.ItemArray[0] != null)
                {
                    CcomboBox.Items.Add(r.ItemArray[0].ToString());
                }
            }
        }
        private void dataBindingComboBox(DataSet dts)
        {
            foreach (DataColumn c in dts.Tables[table].Columns)
            {
                if (c.ColumnName.ToString() == CcomboBox.Reference.ToString())
                {
                    CcomboBox.SelectedIndex = (int)dts.Tables[table].Rows[0].ItemArray[c.Ordinal];
                }
            }
        }

        //canviar entre tipus_client
        private void customTextBox1_TextChanged(object sender, EventArgs e)
        {
            CcomboBox.SelectedIndex = Convert.ToInt32(customTextBox1.Text);
            customTextBox1.TextChanged += new System.EventHandler(this.validarText);
        }

        private void CcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            customTextBox1.Text = CcomboBox.SelectedIndex.ToString();
            customTextBox1.TextChanged += new System.EventHandler(this.validarText);
        }

        //actualitzar base de dades
        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
        }

        public void ActualitzarMySQL(string table)
        {
            Boolean correcte = false;
            correcte = ComprovarCamps();
            if (correcte)
            {
                ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
                correcte = bd.Actualitzar(query, table, dataSet);
                if (correcte)
                {
                    MessageBox.Show("Dades actualitzades");
                    bd.portarPerConsulta(query, table);

                }
                else
                {
                    MessageBox.Show("Error al actualitzar les dades");
                }
            }
            else
            {
                MessageBox.Show("Camps buits");
            }

        }
        private Boolean ComprovarCamps()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {
                    if (txt.Text == "" && (String) txt.Tag != "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //afegir camp datagridview
        private void btnAfegir_Click(object sender, EventArgs e)
        {
            AfegirCamp(table);
        }

        public void AfegirCamp(string table)
        {
            DataRow row = dataSet.Tables[table].NewRow();
            dataSet.Tables[table].Rows.Add(row);
            clientsDataGridView.Rows[clientsDataGridView.Rows.Count - 2].Selected = true;
            clientsDataGridView.CurrentCell = clientsDataGridView.Rows[clientsDataGridView.Rows.Count - 2].Cells[1];
        }

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            String columna = "";

            for (int i = 0; i <= clientsDataGridView.Columns.Count; i++)
            {
                if (clientsDataGridView.Columns[i].HeaderText.Equals(cbClients.Text))
                {
                    columna = clientsDataGridView.Columns[i].Name;
                    break;
                }
            }
            try {
                (clientsDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format(columna + " LIKE '{0}%'", TxBFilter.Text);
            } catch (System.Data.EvaluateException) {
                MessageBox.Show("Error: Caràcters introduits no vàlids");
            }
    
        }
    }
}
