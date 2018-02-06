﻿using System;
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
        

        public override void actualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
            PortarDadesMySQL(table);
        }

        public override void btnAfegir_Click(object sender, EventArgs e)
        {
            AfegirCamp(table);
        }

        private void Laboratoris_Load(object sender, EventArgs e)
        {
            PortarDadesMySQL(table);
        }
        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("codi_laboratori LIKE '{0}%'", TxBFilter.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
