using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Personal
{
    public partial class Personal : BaseForm.BaseForm
    {
        public Personal()
        {
            InitializeComponent();
        }
        string table = "personal";

        public override void actualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarMySQL(table);
            PortarDadesMySQL(table);
        }

        public override void btnAfegir_Click(object sender, EventArgs e)
        {
            AfegirCamp(table);
        }

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            (dgvBase.DataSource as DataTable).DefaultView.RowFilter = string.Format("usuari LIKE '{0}%'", TxBFilter.Text);
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            PortarDadesMySQL(table);
            //Esconder el primer campo que es la primary Key
            this.dgvBase.Columns[0].Visible = false;
            //Alias para las columnas
            this.dgvBase.Columns[1].HeaderText = "Usuari"; //usuari
            this.dgvBase.Columns[2].HeaderText = "Contrasenya"; //contrasenya
        }
    }
}
