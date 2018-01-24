using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class CustomTextBox: TextBox
    {

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

        public void this_Leave(object sender, EventArgs e)
        {
            if (this.Text == "")
            {
                this.Text = _placeholder;
            }
            this.BackColor = Color.White;
        }

        public void CustomControlTB_Load(object sender, EventArgs e)
        {
            this.Text = _placeholder;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomTextBox
            // 
            this.Enter += new System.EventHandler(this.CustomTextBox_Enter);
            this.Leave += new System.EventHandler(this.this_Leave);
            this.ResumeLayout(false);

        }

        private void CustomTextBox_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            if (this.Text == _placeholder)
            {
                this.Text = "";
            }
            this.BackColor = Color.FromArgb(169, 169, 169);
            this.SelectionStart = 0;
            this.SelectionLength = this.Text.Length;

            if (_selectedValue == "Password")
            {
                this.PasswordChar = '*';
            }
            else
            {
                //TODO
            }
        }
    }
}
