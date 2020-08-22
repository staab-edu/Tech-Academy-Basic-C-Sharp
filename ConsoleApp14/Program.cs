using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            NumManip math1 = new NumManip();
            int num = 15;
            Console.WriteLine(num + " added to 20 is " + math1.mymanip(num));

            NumManip math2 = new NumManip();
            decimal dnum = 7.5m;
            Console.WriteLine(dnum + " times 10 is " + math2.mymanip(dnum));

            NumManip math3 = new NumManip();
            string snum = "25";
            Console.WriteLine(snum + " minus 5 is " + math3.mymanip(snum));

            Console.ReadLine();
        }
    }
}
