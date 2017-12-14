using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class paco : Form
    {
        public paco()
        {
            InitializeComponent();
        }

        private void iniciarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new PaginaPrincipal.PaginaPrincipal();
            frm.Show();
        }

        bool drag = false;
        Point start_point = new Point(0,0);

        private void barraAccions_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void barraAccions_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag) {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void barraAccions_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        
        
        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
