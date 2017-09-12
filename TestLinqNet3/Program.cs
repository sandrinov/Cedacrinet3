using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinqNet3
{

    public static class StringConversions
    {
        public static double ToDouble(this string s)
        {
            return Double.Parse(s);
        }
        public static bool ToBool(this string s)
        {
            return Boolean.Parse(s);
        }
    }



    public delegate bool IntFilter(int i);

    public class Common
    {
        public static List<int> FilterArrayOfInts(List<int> ints, IntFilter filter)
        {
            List<int> resultList = new List<int>();
            foreach (int i in ints)
            {
                if (filter(i))
                    resultList.Add(i);
            }
            return resultList;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //UsingLambda();
            //UsingExtensionMethods();

            var user = new {FirstName="Mario", LastName="Rossi", Age=99, HireDate= DateTime.Now.AddDays(-3650) };
            var user1 = new { FirstName = "Mario", LastName = "Rossi", Age = 99, HireDate = DateTime.Now.AddDays(-3650) };

            Console.WriteLine(user.GetType().ToString());
            Console.WriteLine(user1.GetType().ToString());

            var s = "ljlk";
        }

        private static void UsingExtensionMethods()
        {
            String spi = "3.1415926535";
            double d = spi.ToDouble();
        }

        private static void UsingLambda()
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #region Explicit Method
            //IntFilter ptr = new IntFilter(IsOdd);
            //List<int> result = Common.FilterArrayOfInts(ints, ptr);
            #endregion
            #region Anonymous Method         
            //List<int> result = Common.FilterArrayOfInts(ints, delegate (int i) { return ((i & 1) == 1); });
            #endregion
            #region Using Lambda
            //List<int> result = Common.FilterArrayOfInts(ints, i => ((i & 1) == 1));
            List<int> result = Common.FilterArrayOfInts(ints, i =>
            {
                if (i % 5 == 0)
                    return true;
                else
                    return false;
            });
            #endregion
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool IsOdd(int i)
        {
            return ((i & 1) == 1);
        }
    }
}
