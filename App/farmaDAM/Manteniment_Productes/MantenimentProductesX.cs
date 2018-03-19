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
        Boolean firstLaunch = true;

        private void MantenimentProductesX_Load(object sender, EventArgs e)
        {
            
            dgvBase.Location = new Point(-180, 50); 
            dgvBase.Anchor = AnchorStyles.Bottom;
            Table(table);
            amagarCamps();
            //Amaguem id_medicament i id_principiActiu

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
            comboBoxQuery = "Select id_PrincipiActiu, nom from " + PComboBox.Reference;
            DataTable c = bd.searchTableFromQuery(comboBoxQuery);
            addComboBoxDataPrin(c, PComboBox);
        }

        public void amagarCamps()
        {
            this.dgvBase.Columns[0].Visible = false;
            this.dgvBase.Columns[1].Visible = false;
            this.dgvBase.Columns[2].Visible = false;
            this.dgvBase.Columns[7].Visible = false;
            this.dgvBase.Columns[8].Visible = false;
            this.dgvBase.Columns[10].Visible = false;
            CCcodi.Visible = false;
            txtGen.Visible = false;
            txtSubs.Visible = false;
            CCRec.Visible = false;
            CCPrin.Visible = false;
        }
        public void switchComboBoxIndex(ComboBox comboBox)
        {
            if(CCcodi.Text != "" && CCcodi.Text != "True" && CCcodi.Text != "False")
            {
                MComboBox.SelectedValue = CCcodi.Text;
            }
        }

        public void switchComboBoxIndexPrin(ComboBox comboBox)
        {
            if (CCPrin.Text != "" && CCPrin.Text != "True" && CCPrin.Text != "False" && CCPrin.Text != "System.Data.DataRowView")
            {
                PComboBox.SelectedValue = CCPrin.Text;
            }
        }

        public void switchComboBoxIndex(TextBox txt, ComboBox comboBox)
        {
            if(txt.Text != "")
            {
                if(txt.Text.Equals("False"))
                    comboBox.SelectedIndex = 1;
                else
                    comboBox.SelectedIndex = 0;
            }
        }

        public void addComboBoxData(DataTable t, ComboBox comboBox)
        {
            comboBox.DataSource = t;
            comboBox.DisplayMember = "rao_social";
            comboBox.ValueMember = "id_laboratori";

            firstLaunch = false;
        }

        public void addComboBoxDataPrin(DataTable t, ComboBox comboBox)
        {
            comboBox.DataSource = t;
            comboBox.DisplayMember = "nom";
            comboBox.ValueMember = "id_PrincipiActiu";

            firstLaunch = false;
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

        private void MComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(!firstLaunch)
            {
                CCcodi.Text = MComboBox.SelectedValue.ToString();
            }
        }

        private void cboxSubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTextBoxText(cboxSubs, txtSubs);
        }

        private void cboxGeneric_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTextBoxText(cboxGeneric, txtGen);
        }
        public void changeTextBoxText(ComboBox comboBox, TextBox txt)
        {
            if (txt.Name.Equals(CCcodi))
            {
                txt.Text = comboBox.SelectedValue.ToString();
            }
            else
            {
                if (comboBox.SelectedIndex == 1)
                {
                    txt.Text = "False";
                }
                else
                {
                    txt.Text = "True";
                }
            }

        }

        private void customTextBox4_TextChanged(object sender, EventArgs e)
        {
            switchComboBoxIndex(CCRec, ComboRec);
        }

        private void ComboRec_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeTextBoxText(ComboRec, CCRec);
        }

        private void CCPros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                browserURL(CCPros.Text);
            }
        }

        private void browserURL(string url)
        {

            if (url.Contains("www.aemps.gob.es/"))
            {
                Browser.Navigate(url);
            }
            else
            {
                MessageBox.Show("Url no valida");
            }
        }

        private void CCFitxa_TextChanged(object sender, EventArgs e)
        {
            browserURL(CCFitxa.Text);
        }

        private void cbProds_SelectedValueChanged(object sender, EventArgs e)
        {
            filtrarTaula();
        }

        private void TxBFilter_TextChanged_1(object sender, EventArgs e)
        {
            filtrarTaula();
        }

        private void filtrarTaula()
        {
            String columna = "";
            if (cbProds.SelectedIndex >= 0)
            {
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
                    try
                    {
                        string rowFilter = double.TryParse(TxBFilter.Text, out number) ? string.Format(columna + " = '{0}'", TxBFilter.Text) : string.Format(columna + " like '%{0}%'", TxBFilter.Text);
                        (dgvBase.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                    }
                    catch (System.Data.EvaluateException)
                    {
                        MessageBox.Show("Error: Caràcters introduits no vàlids");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Seleciona un camp");
            }
        }

        private void btnAfegir_Click_1(object sender, EventArgs e)
        {
            changeTextBoxText(ComboRec, CCRec);
            changeTextBoxText(cboxGeneric, txtGen);
            changeTextBoxText(cboxSubs, txtSubs);
            changeTextBoxText(MComboBox, CCcodi);
            changeTextBoxText(PComboBox, CCPrin);
        }

        private void CCPrin_TextChanged(object sender, EventArgs e)
        {
            switchComboBoxIndexPrin(PComboBox);
        }

        private void PComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!firstLaunch)
            {
                CCPrin.Text = PComboBox.SelectedValue.ToString();
            }
        }
    }
}
