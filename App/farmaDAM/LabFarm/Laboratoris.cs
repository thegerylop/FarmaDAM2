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
        
        private void Laboratoris_Load(object sender, EventArgs e)
        {
            Table(table);
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
            filtrarTaula();
        }
        private void cbLabs_SelectedValueChanged(object sender, EventArgs e)
        {
            filtrarTaula();
        }

        private void filtrarTaula()
        {
            String columna = "";
            if (cbLabs.SelectedIndex >= 0)
            {
                for (int i = 0; i <= dgvBase.Columns.Count; i++)
                {
                    if (dgvBase.Columns[i].HeaderText.Equals(cbLabs.Text))
                    {
                        columna = dgvBase.Columns[i].Name;
                        break;
                    }
                }

                double number;
                try
                {
                    string rowFilter = double.TryParse(TxBFilter.Text, out number) ? string.Format(columna + " = '{0}'", TxBFilter.Text) : string.Format(columna + " like '%{0}%'", TxBFilter.Text);
                    (dgvBase.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                }
                catch
                {
                    MessageBox.Show("Caràcters introduits incorrectes");
                }
            }
            else
            {
                MessageBox.Show("Seleciona un camp");
            }
        }
    }
}
