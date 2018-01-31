using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Personal
{
    public partial class Personal : BaseForm.BaseForm
    {
        public Personal()
        {
            InitializeComponent();
        }
        string table = "Personal";

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

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("usuari LIKE '{0}%'", TxBFilter.Text);
        }
    }
}
