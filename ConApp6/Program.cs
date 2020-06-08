using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tics = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool qualified = age > 15 && !dui && tics <= 3;
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
