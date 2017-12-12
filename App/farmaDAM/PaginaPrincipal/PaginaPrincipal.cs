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
        ConexioBBDD.Conexio info = new ConexioBBDD.Conexio();

        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form frm = new farmaDAM.AcercaDe();
            frm.Show();
        }

        private void buttonCreateTest_Click(object sender, EventArgs e)
        {
            string create = "CREATE TABLE TEST(test int(3))";
            info.connexioBD(create);
            
        }
    }
}
