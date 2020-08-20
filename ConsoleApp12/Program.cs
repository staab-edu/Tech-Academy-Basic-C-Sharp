using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 10, 15, 26, 33, 50, 73, 80 };

            Console.WriteLine("Ender number to devide by");
            int div = Convert.ToInt32(Console.ReadLine());
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " divided by " + div + " = " + number / div);
            }
            Console.ReadLine();
        }
    }
}
