﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manteniment_Productes
{
    public partial class Manteniment_Productes : BaseForm.BaseForm
    {
        public Manteniment_Productes()
        {
            InitializeComponent();
        }

        string table = "mantenimentProductes";

        private void Productes_Load (object sender, EventArgs e)
        {
            Table(table);
            //Amaguem id_medicament i id_principiActiu
            this.dgvBase.Columns[0].Visible = false;
            this.dgvBase.Columns[1].Visible = false;
            //Alies pels altres camps
            this.dgvBase.Columns[2].HeaderText = "Nom comercial"; //nom_comercial
            this.dgvBase.Columns[3].HeaderText = "Nº registre nacional"; //registre_nacional
            this.dgvBase.Columns[4].HeaderText = "Quantitat"; //contingut
            this.dgvBase.Columns[5].HeaderText = "Substituïble"; //substituible
            this.dgvBase.Columns[6].HeaderText = "Genèric"; //generic
            this.dgvBase.Columns[7].HeaderText = "PVP"; //PVP
            this.dgvBase.Columns[8].HeaderText = "% d'IVA"; //IVA
            this.dgvBase.Columns[9].HeaderText = "Recepta"; //recepta
            this.dgvBase.Columns[10].HeaderText = "Fitxa tècncica"; //url_fitxa_tecnica
            this.dgvBase.Columns[11].HeaderText = "Prospecte"; //url_prospecte
            this.dgvBase.Columns[12].HeaderText = "Stock"; //id_stock
            this.dgvBase.Columns[13].HeaderText = "Codi Laboratori"; //codi_laboratori
            //Amaguem id_la
            this.dgvBase.Columns[14].Visible = false;
        }

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            String columna = "";

            for (int i = 1; i <= dgvBase.Columns.Count; i++)
            {
                if (dgvBase.Columns[i].HeaderText.Equals(cbProds.Text))
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
