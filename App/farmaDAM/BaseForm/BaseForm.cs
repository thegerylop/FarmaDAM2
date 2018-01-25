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
using CustomControlTB;
namespace BaseForm
{

    public partial class BaseForm : Form
    {
        String query = "";
        DataRow row;
        DataSet dataSet = new DataSet();

        public void PortarDadesMySQL(string table)
        {
            ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query);
            BindingDades();
           // bd = null;
        }
        public void ActualitzarMySQL(string table)
        {
            Boolean correcte = false;
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

        private void BindingDades()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControl.CustomTextBox))
                {

                    txt.DataBindings.Clear();
                    txt.DataBindings.Add("Text", dataSet.Tables["laboratoris_farmaceutics"], txt.Tag.ToString(),true);
                    txt.Validated += new System.EventHandler(this.validarText);

                    //AddHandler DirectCast(txt, System.Windows.Forms.TextBox).Validated, _
                    //txt.DataBindings.
                    //AddressOf validartext

                }
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataSet.Tables["laboratoris_farmaceutics"]; // dataset
        }

        private void validarText(object sender, EventArgs e)
        {
            //textBox tb = (TextBox)sender;
        }
        public BaseForm()
        {
            InitializeComponent();
        }
        public virtual void btnInserir_Click(object sender, EventArgs e)
        {
        }

        public virtual void actualitzar_Click(object sender, EventArgs e)
        {
        }

        private void btnEsborrar_Click(object sender, EventArgs e)
        {
            
            //netejarCamps();
            row = dataSet.Tables["laboratoris_farmaceutics"].NewRow();
            dataSet.Tables["laboratoris_farmaceutics"].Rows.Add(row);
            
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
    }
}
