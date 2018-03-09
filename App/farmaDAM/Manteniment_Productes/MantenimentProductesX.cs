using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manteniment_Productes
{
    public partial class MantenimentProductesX : BaseForm.BaseForm
    {
        public MantenimentProductesX()
        {
            InitializeComponent();
        }
        BaseForm.BaseForm baseForm = new BaseForm.BaseForm();

        String table = "medicaments";
        String comboBoxQuery;
        ConexioBBDD.Conexio bd = new ConexioBBDD.Conexio();
        Boolean flag;

        private void MantenimentProductesX_Load(object sender, EventArgs e)
        {
            dgvBase.Anchor = AnchorStyles.Bottom;
            Table(table);
            //Amaguem id_medicament i id_principiActiu
            this.dgvBase.Columns[0].Visible = false;
            this.dgvBase.Columns[1].Visible = false;
            this.dgvBase.Columns[2].Visible = false;

            //Alies pels altres camps
            this.dgvBase.Columns[3].HeaderText = "Nº registre nacional"; //registre_nacional
            this.dgvBase.Columns[4].HeaderText = "Nom"; //nom_comercial
            this.dgvBase.Columns[5].HeaderText = "Contingut"; //substituible
            this.dgvBase.Columns[6].HeaderText = "% d'IVA"; //IVA
            this.dgvBase.Columns[7].HeaderText = "Substituïble"; //substituible
            this.dgvBase.Columns[8].HeaderText = "Genèric"; //generic
            this.dgvBase.Columns[9].HeaderText = "PVP"; //PVP
            this.dgvBase.Columns[10].HeaderText = "Recepta"; //recepta
            this.dgvBase.Columns[11].HeaderText = "Fitxa tècncica"; //url_fitxa_tecnica
            this.dgvBase.Columns[12].HeaderText = "Prospecte"; //url_prospecte
            this.dgvBase.Columns[13].HeaderText = "Stock"; //stock

            comboBoxQuery = "Select id_laboratori, rao_social from " + MComboBox.Reference;
            DataTable t = bd.searchTableFromQuery(comboBoxQuery);
            addComboBoxData(t, MComboBox);

            CCcodi.Visible = true;
            txtGen.Visible = true;
            txtSubs.Visible = true;
        }

        public void switchComboBoxIndex(ComboBox comboBox)
        {
            MComboBox.SelectedValue = CCcodi.Text;
        }

        public void switchComboBoxIndex(TextBox txt, ComboBox comboBox)
        {
            if (txt.Equals("False"))
                comboBox.SelectedValue = "2";
            else
                comboBox.SelectedValue = "1";
        }

        public void addComboBoxData(DataTable t, ComboBox comboBox)
        {
            comboBox.DataSource = t;
            comboBox.DisplayMember = "rao_social";
            comboBox.ValueMember = "id_laboratori";
        }

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            String columna = "";
            if (cbProds.Text != "")
            {
                for (int i = 1; i <= dgvBase.Columns.Count; i++)
                {
                    if (dgvBase.Columns[i].HeaderText.Equals(cbProds.Text))
                    {
                        columna = dgvBase.Columns[i].Name;
                        break;
                    }
                }
                double number;
                try { 
                    string rowFilter = double.TryParse(TxBFilter.Text, out number) ? string.Format(columna + " = '{0}'", TxBFilter.Text) : string.Format(columna + " like '%{0}%'", TxBFilter.Text);(dgvBase.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    (dgvBase.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                } catch (System.Data.EvaluateException) {
                    MessageBox.Show("Error: Caràcters introduits no vàlids");
                }
                
            }
        }

        private void CCcodi_TextChanged(object sender, EventArgs e)
        {
            switchComboBoxIndex(MComboBox);
        }

        private void txtSubs_TextChanged(object sender, EventArgs e)
        {
            switchComboBoxIndex(txtSubs, cboxSubs);
        }

        private void txtGen_TextChanged(object sender, EventArgs e)
        {
            switchComboBoxIndex(txtGen, cboxGeneric);
        }
    }
}
