using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clients
{
    public partial class Clients : Form
    {
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();
        
        public Clients()
        {
            InitializeComponent();
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cronicGB.Hide();
        }

        private void siRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cronicGB.Show();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM clients";
            DataTable data = new DataTable();
            data = conn.filltable(query);
            cronicGridView.DataSource = data;
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            Object[] dades;
            if (siRadioButton.Checked) {
                dades = new Object[8];
            } else
            {
                dades = new Object[7];
            }

            dades = dadesTextBox(dades);

            comprovarDades();
        }

        private Object[] dadesTextBox(Object [] dades) {

            dades[0] = customNom.textBox1.Text;
            dades[1] = customCognoms.textBox1.Text;
            dades[2] = customDNI.textBox1.Text;
            dades[3] = customAdreca.textBox1.Text;
            dades[4] = customTS.textBox1.Text;
            dades[5] = siRadioButton.Checked;
            dades[6] = tcDropDown.Text;
            if (dades.Length == 8) {
                dades[7] = customEmail.textBox1.Text;
            }

            return dades;
        }

        private bool comprovarDades() {

            return false;
        }

        private void customNom_Load(object sender, EventArgs e)
        {

        }
    }
}
