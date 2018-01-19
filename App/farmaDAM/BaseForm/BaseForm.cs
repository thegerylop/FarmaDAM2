using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm
{

    public partial class BaseForm : Form
    {
        String query = "";
        DataSet dataSet = new DataSet();


        public BaseForm()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {

        }
    }
}
