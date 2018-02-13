using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexioBBDD;
namespace BaseForm
{

    public partial class BaseForm : Form
    {
        String query = "";
        DataRow row;
        DataSet dataSet = new DataSet();
        String table = "";
        public BaseForm()
        {
            InitializeComponent();
        }
        public void Table(string value)
        {
            table = value;
            PortarDadesMySQL(table);
        }
        public void PortarDadesMySQL(string table)
        {
            ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query, table);
            BindingDades(table);
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
                    if (txt.Text == "" && txt.Tag != "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void BindingDades(string table)
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {
                    if (txt.Tag.ToString() != "") {
                        txt.DataBindings.Clear();
                        txt.DataBindings.Add("Text", dataSet.Tables[table], txt.Tag.ToString(), true);
                        txt.Validated += new System.EventHandler(this.validarText);
                    }
                }
            }
            dgvBase.AutoGenerateColumns = true;
            dgvBase.DataSource = dataSet.Tables[table]; // dataset
        }

        private void validarText(object sender, EventArgs e)
        {
            Control test = (Control)sender;
            test.DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
        public virtual void btnAfegir_Click(object sender, EventArgs e)
        {
            AfegirCamp(table);
        }
        public virtual void actualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
        }
        public void netejarCamps()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {
                    txt.Text = "";
                }
            }
        }
        public void AfegirCamp(string table)
        {
            row = dataSet.Tables[table].NewRow();
            dataSet.Tables[table].Rows.Add(row);
            dgvBase.Rows[dgvBase.Rows.Count - 2].Selected = true;
            dgvBase.CurrentCell = dgvBase.Rows[dgvBase.Rows.Count - 2].Cells[1];
        }
       

        private void dgvBase_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Entrada no vàlida");
            dgvBase.RefreshEdit();
        }
    }
}