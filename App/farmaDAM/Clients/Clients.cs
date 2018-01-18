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
        public Clients()
        {
            InitializeComponent();
            cronicGB.Hide();
        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cronicGB.Hide();
        }

        private void siRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cronicGB.Show();
        }
    }
}
