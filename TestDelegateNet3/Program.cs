using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegateNet3
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager mm = new MailManager();
            Fax fax = new Fax(mm);
            Printer prn = new Printer(mm);

            mm.SimulateEmailArrived(new Email() { From="Topolino", Body="Minni, usciamo stasera?" });
            mm.SimulateEmailArrived(new Email() { From = "Minni", Body = "No esco con Pippo" });
        }
    }
}
