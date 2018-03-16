using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace gestioComandes
{
    public partial class gestioDeComandes : Form
    {
        CarregarDades.carregarDades Carregar = new CarregarDades.carregarDades();
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();
        String data;
        String xml;
        Boolean correcte = true;

        public gestioDeComandes()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data = dataComanda.Value.ToString("yyyy-MM-dd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comandaCrystalReports();
            DataSet xmlData = new DataSet();
            string query = "select distinct nom_comercial, sum(quantitat) AS quantitat, vendes.data from medicaments, linia_venda, vendes where vendes.id_venda = linia_venda.id_venda and medicaments.id_medicament = linia_venda.id_medicament and date(vendes.data) = '"+ data + "' group by nom_comercial";
            xmlData = conn.portarPerConsulta(query , "comanda");
            xml = Carregar.writeXML(xmlData);
            richXML.Text = xml;
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (correcte)
            {
                Carregar.saveXML(xml, data);
            }
            else
            {
                MessageBox.Show("Xml incorrecte");
            }
            
        }

        private void btnDTD_Click(object sender, EventArgs e)
        {
            correcte = Carregar.dtd(xml, data);
        }

        private void gestioDeComandes_Load(object sender, EventArgs e)
        {
            data = dataComanda.Value.ToString("yyyy-MM-dd");
        }
    }
}
