using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client
{
    public partial class Client : BaseForm.BaseForm
    {
        public Client()
        {
            InitializeComponent();
        }

        string table = "clients";

        private void Client_Load(object sender, EventArgs e)
        {
            Table(table);
            //Esconder el primer campo que es la primary Key
            this.dgvBase.Columns[0].Visible = false;
        }
    }
}
