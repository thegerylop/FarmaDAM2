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
            
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;

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

        public override void btnXML_Click(object sender, EventArgs e)
        {
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void Laboratoris_Load(object sender, EventArgs e)
        {
            PortarDadesMySQL(table);
            //Esconder el primer campo que es la primary Key
            this.dgvBase.Columns[0].Visible = false;
            //Alias para las columnas
            this.dgvBase.Columns[1].HeaderText = "Codi Laboratori"; //codi_laboratori
            this.dgvBase.Columns[2].HeaderText = "Raó Social"; //rao_social
            this.dgvBase.Columns[3].HeaderText = "CIF"; //cif
            this.dgvBase.Columns[4].HeaderText = "Denominació"; //denominacio
        }
        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            double number;
            string rowFilter = double.TryParse(TxBFilter.Text, out number) ?
                string.Format("codi_laboratori='{0}'", TxBFilter.Text) :
                string.Format("codi_laboratori like '%{0}%'", TxBFilter.Text);
            (dgvBase.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    System.Threading.Thread.Sleep(250);
            //    backgroundWorker1.ReportProgress(i);
            //}

            base.btnXML_Click(sender, e);
            TractarXML.Class1 xml = new TractarXML.Class1();
            xml.ReadXML(table);

        }
        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
          
        }
    }
}
