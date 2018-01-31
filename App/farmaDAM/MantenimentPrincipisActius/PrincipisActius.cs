using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MantenimentPrincipisActius
{
    public partial class PrincipisActius : BaseForm.BaseForm
    {
        public PrincipisActius()
        {
            InitializeComponent();
        }
        string table = "principisActius";

        public override void btnInserir_Click(object sender, EventArgs e)
        {
            PortarDadesMySQL(table);
        }

        public override void actualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
        }

        public override void btnAfegir_Click(object sender, EventArgs e)
        {
            AfegirCamp(table);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrincipisActius_Load(object sender, EventArgs e)
        {

        }
    }
}
