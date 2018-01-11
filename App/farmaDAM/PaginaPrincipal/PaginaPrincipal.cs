using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Template();
            frm.Show();
        }
    }
}
