using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
    public partial class Client : BaseForm.BaseForm
    {
        public Client()
        {
            InitializeComponent();
        }

        string table = "taula";
        string query = "SELECT e.dni,e.nom,e.cognom1,e.cognom2,e.direccio,t.nom_carnet,e.t_sanitaria,e.punts,e.cronic FROM clients e, tipus_carnet t WHERE e.tipus_carnet = t.id_carnet";

        private void Client_Load(object sender, EventArgs e)
        {
            //Esconder el primer campo que es la primary Key
            this.dgvBase.Columns[0].Visible = false;
        }

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            String columna = "";
            if (cbClients.Text != "")
            {
                for (int i = 1; i <= dgvBase.Columns.Count; i++)
                {
                    if (dgvBase.Columns[i].HeaderText.Equals(cbClients.Text))
                    {
                        columna = dgvBase.Columns[i].Name;
                        break;
                    }
                }
                double number;
                string rowFilter = double.TryParse(TxBFilter.Text, out number) ? string.Format(columna + " = '{0}'", TxBFilter.Text) : string.Format(columna + " like '%{0}%'", TxBFilter.Text);
                (dgvBase.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }
    }
}
