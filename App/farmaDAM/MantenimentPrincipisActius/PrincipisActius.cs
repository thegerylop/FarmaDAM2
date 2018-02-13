﻿using System;
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
            Table(table);
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("nom LIKE '{0}%'", TxBFilter.Text);
        }
    }
}
