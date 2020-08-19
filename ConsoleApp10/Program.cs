using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Red", "Blue", "White", "Green", "Yellow"};
            int[] primes = { 1, 3, 5, 7, 11, 13 };
            var Fruit = new List<string>();
            Fruit.Add("banana");
            Fruit.Add("grape");
            Fruit.Add("Strawberry");
            Fruit.Add("cberry");
            Fruit.Add("blueberry");

            Console.WriteLine("Please pick a number from 0-4");
            int ind = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(colors[ind]);

            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine("Please pick a number");
                ind = Convert.ToInt32(Console.ReadLine());

                if (ind < 0 || ind > primes.Length)
                {
                    Console.WriteLine("Invalid index for array.  Pick a number from 0 to 5.");
                }
                else
                {
                    Console.WriteLine(primes[ind]);
                    invalid = false;
                }
            }

            Console.WriteLine("Please pick a number from 0-4");
            ind = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fruit[ind]);
            Console.ReadLine();

        }
    }
}
