using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace gestioComandes
{
    public partial class gestioDeComandes : Form
    {

        String data;

        public gestioDeComandes()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data = dataComanda.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comandaCrystalReports();
        }

        private void comandaCrystalReports()
        {
            //Crea la comanda i s'envia al viewer
            ReportDocument comanda = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            comanda.Load("../gestioComandes/Comanda.rpt");

            crConnectionInfo.ServerName = "farmaDAM";
            crConnectionInfo.DatabaseName = "g2s2am_FarmaDAM";
            crConnectionInfo.UserID = "g2s2am";
            crConnectionInfo.Password = "diopters12345";

            CrTables = comanda.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            String dataDeVendes = dataComanda.Value.ToString();
            String dataFormatada = Convert.ToDateTime(dataDeVendes).ToString("yyyy-MM-dd");
            comanda.RecordSelectionFormula = "{vendes1.data} = #" + dataFormatada + "#";
            crystalReportViewer1.ReportSource = comanda;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
