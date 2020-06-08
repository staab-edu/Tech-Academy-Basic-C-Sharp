using System;

namespace ConApp5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            decimal rate1;
            decimal.TryParse(Console.ReadLine(),out rate1);
            Console.WriteLine("Hours worked");
            decimal hours1;
            decimal.TryParse(Console.ReadLine(), out hours1);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            decimal rate2;
            decimal.TryParse(Console.ReadLine(), out rate2);
            Console.WriteLine("Hours worked");
            decimal hours2;
            decimal.TryParse(Console.ReadLine(), out hours2);
            decimal tot1 = rate1 * hours1 * 52.0m;
            decimal tot2 = rate2 * hours2 * 52.0m;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(tot1);
            Console.WriteLine("Annual salary of Person :");
            Console.WriteLine(tot2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(tot1 > tot2);

            Console.ReadLine();
        }
    }
}
