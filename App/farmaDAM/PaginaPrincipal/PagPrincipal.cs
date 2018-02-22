using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaginaPrincipal
{
    public partial class PagPrincipal : TemplateForm.TemplateForm
    {
        public PagPrincipal()
        {
            InitializeComponent();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void Laboratoris_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form frm = new LabFarm.Laboratoris();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void PrincipisActius_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MantenimentPrincipisActius.PrincipisActius frm = new MantenimentPrincipisActius.PrincipisActius();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void Personal_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Personal.Personal frm = new Personal.Personal();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void MantenimentProductes_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Manteniment_Productes.Manteniment_Productes frm = new Manteniment_Productes.Manteniment_Productes();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tancarSessioButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void btn_CarregaDades_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CarregarDades.carregarDades frm = new CarregarDades.carregarDades();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
