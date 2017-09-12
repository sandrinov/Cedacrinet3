using MathLibNet3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNet3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //Int32 x = 10;
            Int32 x = new Int32();
            x = 10;
            int y = 20;
            String result = "Il risultato è: ";
            //int z = Add(x, y);

            SimpleMath sm = new SimpleMath();
            int z = sm.Add(x, y);



            Console.WriteLine(result + z);


            String s = "a";
            s += "b";
            Console.WriteLine(s);
        }

        private static int Add(int add1, int add2)
        {
            Bitmap btm;
            return add1 + add2;
        }
    }
}
