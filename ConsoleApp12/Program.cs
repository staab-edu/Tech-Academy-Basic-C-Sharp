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
            string input = (Console.ReadLine());
            int divisor;
            int result;
            foreach (int number in numbers)
            {
                divisor = 0;
                result = 0;
                try
                {

                    divisor = Convert.ToInt32(input);
                    result = number / divisor;
                } catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception caugt : {0}", e.Message);
                } catch (FormatException e)
                {
                    Console.WriteLine("Exception caugt : {0}", e.Message);
                } finally
                {
                    if (divisor != 0 && result != 0)
                    {
                        Console.WriteLine(number + " divided by " + divisor + " = " + result);
                    }
                }
                

            }
            Console.WriteLine("\nCompleted loop");
            Console.ReadLine();
        }
    }
}
