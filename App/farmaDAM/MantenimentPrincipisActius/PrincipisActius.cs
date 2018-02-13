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
        string table = "principis_actius";

        public override void btnInserir_Click(object sender, EventArgs e)
        {
            PortarDadesMySQL(table);
        }

        public override void actualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
            PortarDadesMySQL(table);
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
            PortarDadesMySQL(table);
            this.dataGridView1.Columns[0].Visible = false;
            //Alias para las columnas
            this.dataGridView1.Columns[1].HeaderText = "Nom"; //nom
            this.dataGridView1.Columns[2].HeaderText = "Número Registre Sanitari"; //num_RegistreSanitari
            this.dataGridView1.Columns[3].HeaderText = "Codi"; //codi
        }

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("nom LIKE '{0}%'", TxBFilter.Text);
        }
    }
}
