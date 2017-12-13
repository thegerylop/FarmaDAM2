using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class TextViewCustomControl : UserControl
    {
        public TextViewCustomControl()
        {
            InitializeComponent();
            
        }

        String _placeholder;
        public String Placeholder
        {
            get
            {
                return _placeholder;
            }
            set
            {
                _placeholder = value;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(153, 180, 209);
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
        }

        private void TextViewCustomControl_Load(object sender, EventArgs e)
        {
            textBox1.Text = _placeholder;
        }
    }
}
