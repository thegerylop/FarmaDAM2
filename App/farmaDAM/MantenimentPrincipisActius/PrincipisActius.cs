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

        private void PrincipisActius_Load(object sender, EventArgs e)
        {
            cbActius.SelectedIndex = 0;
            Table(table);
            this.dgvBase.Columns[0].Visible = false;
            //Alias para las columnas
            this.dgvBase.Columns[1].HeaderText = "Nom"; //nom
            this.dgvBase.Columns[2].HeaderText = "Número Registre Sanitari"; //num_RegistreSanitari
            this.dgvBase.Columns[3].HeaderText = "Codi"; //codi
        }

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            (dgvBase.DataSource as DataTable).DefaultView.RowFilter = string.Format("nom LIKE '{0}%'", TxBFilter.Text);
        }

        private void TxBFilter_TextChanged_1(object sender, EventArgs e)
        {
            String columna = "";
            if (cbActius.Text != "")
            {
                for (int i = 1; i <= dgvBase.Columns.Count; i++)
                {
                    if (dgvBase.Columns[i].HeaderText.Equals(cbActius.Text))
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
