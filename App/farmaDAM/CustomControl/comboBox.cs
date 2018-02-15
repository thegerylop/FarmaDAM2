using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomControl
{
    public class comboBox : ComboBox
    {
        String _reference;
        public String Reference
        {
            get
            {
                return _reference;
            }
            set
            {
                _reference = value;
            }
        }
    }
}
