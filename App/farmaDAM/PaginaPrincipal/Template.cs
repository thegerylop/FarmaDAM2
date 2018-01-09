using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaPrincipal
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }
        private void labelExitLog_MouseHover(object sender, EventArgs e)
        {
            labelExitLog.Font = new Font(labelExitLog.Font.Name, labelExitLog.Font.SizeInPoints, FontStyle.Underline);
        }
    }
}
