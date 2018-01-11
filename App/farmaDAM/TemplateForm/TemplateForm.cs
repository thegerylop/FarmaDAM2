using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateForm
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        public void button5_Click(object sender, EventArgs e)
        {

        }

        public void button10_Click(object sender, EventArgs e)
        {
            Form frm = new LabFarm.Laboratoris();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            
        }

        private void labelExitLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
