using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabFarm
{
    public partial class Laboratoris : BaseForm.BaseForm
    {
        public Laboratoris()
        {
            InitializeComponent();
        }
        string table = "laboratoris_farmaceutics";
        private void btnEsborrar_Click(object sender, EventArgs e)
        {
            CCcif.textBox1.Text = "";
            CCcodi.textBox1.Text = "";
            CCden.textBox1.Text = "";
            CCid.textBox1.Text = "";
            CCrao.textBox1.Text = "";
        }

        public override void btnInserir_Click(object sender, EventArgs e)
        {
            PortarDadesMySQL(table);
        }

        public override void actualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
        }
    }
}
