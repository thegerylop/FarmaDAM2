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
    public partial class TemplateForm1 : Form
    {
        string User;

        public void Username(string value)
        {
            
            lblUser.Text = "Usuari: " + value;

        }
        public TemplateForm1()
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
            panel1.Controls.Clear();
            Form frm = new LabFarm.Laboratoris();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            date.Text = DateTime.Now.ToString();
        }

        private void labelExitLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            ////lblTitle.Text = "Clients";
            //Form frm = new Clients.Clients();
            //frm.TopLevel = false;
            //panel1.Controls.Add(frm);
            //frm.Dock = DockStyle.Fill;
            //frm.Show();
        }

        private void tancarSessioButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Personal.Personal frm = new Personal.Personal();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Manteniment_Productes.Manteniment_Productes frm = new Manteniment_Productes.Manteniment_Productes();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MantenimentPrincipisActius.PrincipisActius frm = new MantenimentPrincipisActius.PrincipisActius();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
