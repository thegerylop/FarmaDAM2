using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestioComandes
{
    public partial class gestioDeComandes : Form
    {

        String data;

        public gestioDeComandes()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data = dataComanda.Value.ToString();
        }
    }
}
