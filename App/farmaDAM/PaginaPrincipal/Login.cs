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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iniciarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new PaginaPrincipal();
            frm.Show();
        }

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void actionBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void actionBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void actionBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void labelExitLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
