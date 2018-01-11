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
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void labelExitLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form frm = new VendaMedicaments();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
