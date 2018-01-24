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
        DataSet dataSet = new DataSet();


        public void PortarDadesMySQL(string table)
        {
            ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
            query = "Select * from " + table;
            dataSet = bd.portarPerConsulta(query);
            BindingDades();
            bd = null;
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
                    txt.DataBindings.Add("Text", dataSet.Tables["laboratoris_farmaceutics"], txt.Tag.ToString());
                    //AddHandler DirectCast(txt, System.Windows.Forms.TextBox).Validated, _
                    //AddressOf validartext
                }
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataSet; // dataset
            dataGridView1.DataMember = "laboratoris_farmaceutics"; // table name you need to show
        }
        private void validarText(object sender , EventArgs e)
        {
            //DirectCast(sender, Windows.Forms.Control).DataBindings(0) _
            //.BindingManagerBase.EndCurrentEdit()
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
        }
    }
}
