using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateNet3
{
    public class Printer
    {
        private MailManager _mm;

        public Printer(MailManager mm)
        {
            this._mm = mm;
            _mm.EmailArrived += _mm_EmailArrived;
        }

        private void _mm_EmailArrived(object sender, Email e)
        {
            Console.WriteLine("PRINTER: From {0} Text {1}", e.From, e.Body);
        }
    }
}
