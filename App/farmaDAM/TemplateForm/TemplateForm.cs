﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateForm
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
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
        public void button5_Click(object sender, EventArgs e)
        {

        }

        public void button10_Click(object sender, EventArgs e)
        {
            Form frm = new LabFarm.Laboratoris();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            
        }

        private void labelExitLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
