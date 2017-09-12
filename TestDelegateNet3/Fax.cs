using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateNet3
{
    public class Fax
    {
        private MailManager _mm;

        public Fax(MailManager mm)
        {
            this._mm = mm;
            EmailArrivedEventHAndler ptr = new EmailArrivedEventHAndler(this.MyEventHandler);
            _mm.EmailArrived += ptr;

        }

        public void MyEventHandler (object sender, Email e)
        {
            Console.WriteLine("FAX: From {0} Text {1}", e.From, e.Body);
        }
    }
}
