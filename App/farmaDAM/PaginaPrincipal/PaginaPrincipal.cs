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

namespace PaginaPrincipal
{
    public partial class PaginaPrincipal : Form
    {
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void buttonCreateTest_Click(object sender, EventArgs e)
        {
           string comanda = "SELECT * from personal";
           
           MessageBox.Show(conn.consulta_BD(comanda).ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
