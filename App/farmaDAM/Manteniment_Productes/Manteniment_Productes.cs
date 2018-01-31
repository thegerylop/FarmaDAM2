using System;
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
        string table = "laboratorisFarmaceutics";
        public Manteniment_Productes()
        {
            InitializeComponent();
        }

        private void btnEsborrar_Click(object sender, EventArgs e)
        {

        }

        public override void btnInserir_Click(object sender, EventArgs e)
        {
            PortarDadesMySQL(table);
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {

        }
    }
}
