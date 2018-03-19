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
        ConexioBBDD.Conexio conn = new ConexioBBDD.Conexio();
        Boolean nouUsuari = false;
        public Personal()
        {
            InitializeComponent();
        }
        string table = "personal";
        
        

        private void TxBFilter_TextChanged(object sender, EventArgs e)
        {
            try {
                (dgvBase.DataSource as DataTable).DefaultView.RowFilter = string.Format("usuari LIKE '{0}%'", TxBFilter.Text);
            } catch (System.Data.EvaluateException) {
                MessageBox.Show("Error: Caràcters introduits no vàlids");
            }            
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            Table(table);
            //Esconder el primer campo que es la primary Key
            this.dgvBase.Columns[0].Visible = false;
            //Alias para las columnas
            this.dgvBase.Columns[1].HeaderText = "Usuari"; //usuari
            this.dgvBase.Columns[2].Visible = false;
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (nouUsuari)
            {
                string contrasenya = CCrao.Text;
                string query = "update personal set contrasenya =  PASSWORD('" + contrasenya + "') where contrasenya = '" + contrasenya + "' and usuari = '" + CCcodi.Text + "'";
                conn.executaComanda(query);
            }
           
        }

        private void btnAfegir_Click_1(object sender, EventArgs e)
        {
            nouUsuari = true;
        }
    }
}
