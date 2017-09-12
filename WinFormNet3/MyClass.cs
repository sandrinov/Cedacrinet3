using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNet3
{
    public class MyClass
    {
        private Button _btn;

        public MyClass(Button btn)
        {
            _btn = btn;
            _btn.Click += _btn_Click;
        }
        private void _btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click handled by MyClass");
        }
    }
}
