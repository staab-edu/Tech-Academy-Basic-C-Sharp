using System;

namespace ConApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            decimal weight;
            decimal.TryParse(Console.ReadLine(), out weight);
            if (weight <=50m)
                {
                    Console.WriteLine("Please enter the package width:");
                    decimal width;
                    decimal.TryParse(Console.ReadLine(), out width);
                    Console.WriteLine("Please enter the package height:");
                    decimal height;
                    decimal.TryParse(Console.ReadLine(), out height);
                    Console.WriteLine("Please enter the package length:");
                    decimal length;
                    decimal.TryParse(Console.ReadLine(), out length);
                    decimal rate = (weight*width * height * length) / 100m;
                    Console.WriteLine("Your estimated total for shipping this package is: " + rate.ToString("C2"));
                    Console.WriteLine("Thank you.");
                }
                else
                {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                }

            Console.WriteLine("Hit enter");
            Console.ReadLine();
        }
    }
}
