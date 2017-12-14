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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(5);
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                Form frm = new Login();
                frm.Show();
                this.Hide();
            }
        }
    }
}
