using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlTB
{
    public partial class CustomControlTB : UserControl
    {
        public CustomControlTB()
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
        public enum Items
        {
            Password,
            Text,
            eMail,
        }
        Items _options;
        
        public Items Options
        {
            get
            {
                return _options;
            }
            set
            {
                _options = value;
                _selectedValue = _options.ToString();
            }
        }
        string _selectedValue;

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = _placeholder;
            }
            textBox1.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == _placeholder)
            {
                textBox1.Text = "";
            }
            textBox1.BackColor = Color.FromArgb(153, 180, 209);
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;

            if(_selectedValue == "Password")
            {
                
            }
            else if(_selectedValue == "eMail")
            {

            }
            else
            {

            }
        }

        private void CustomControlTB_Load(object sender, EventArgs e)
        {
            textBox1.Text = _placeholder;
        }
    }
}
