using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateNet3
{

    public class Email
    {
        public String From { get; set; }
        public String Body { get; set; }
    }

    public delegate void EmailArrivedEventHAndler(object sender, Email e);

    public class MailManager
    {
        public event EmailArrivedEventHAndler EmailArrived;

        public void SimulateEmailArrived(Email e)
        {
            if (EmailArrived != null)
                EmailArrived(this, e);
        }
    }
}
