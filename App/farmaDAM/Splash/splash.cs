using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(5);
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                Form frm = new Login.Login();
                frm.Show();
                this.Hide();
            }
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void farmadamImg_Click(object sender, EventArgs e)
        {

        }
    }
}
