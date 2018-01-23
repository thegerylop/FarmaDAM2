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
        String query = "Select * from laboratoris_farmaceutics";
        DataSet dataSet = new DataSet();


        private void PortarDadesMySQL()
        {
            ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
            query = "Select * from laboratoris_farmaceutics";
            dataSet = bd.portarPerConsulta(query);
            BindingDades();
            bd = null;
        }

        private void ActualitzarMySQL()
        {
            Boolean correcte = false;
            ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
            correcte = bd.Actualitzar(query, "laboratoris_farmaceutics", dataSet);
        }

        private void BindingDades()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt.GetType() == typeof(CustomControlTB.CustomControlTB))
                {
                    txt.DataBindings.Clear();
                    txt.DataBindings.Add("Text", dataSet.Tables["laboratoris_farmaceutics"], txt.Tag.ToString());
                }
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataSet; // dataset
            dataGridView1.DataMember = "laboratoris_farmaceutics"; // table name you need to show
        }

        

        public BaseForm()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            PortarDadesMySQL();
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
        }
    }
}
