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
        

        public override void actualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
            PortarDadesMySQL(table);
        }

        public override void btnAfegir_Click(object sender, EventArgs e)
        {
            AfegirCamp(table);
        }

        private void Laboratoris_Load(object sender, EventArgs e)
        {
            PortarDadesMySQL(table);
            //Esconder el primer campo que es la primary Key
            this.dataGridView1.Columns[0].Visible = false;
            //Alias para las columnas
            this.dataGridView1.Columns[1].HeaderText = "Codi Laboratori"; //codi_laboratori
            this.dataGridView1.Columns[2].HeaderText = "Raó Social"; //rao_social
            this.dataGridView1.Columns[3].HeaderText = "CIF"; //cif
            this.dataGridView1.Columns[4].HeaderText = "Denominació"; //denominacio
        }
        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            double number;
            string rowFilter = double.TryParse(TxBFilter.Text, out number) ?
                string.Format("codi_laboratori='{0}'", TxBFilter.Text) :
                string.Format("codi_laboratori like '%{0}%'", TxBFilter.Text);
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
