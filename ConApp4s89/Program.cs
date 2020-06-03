using System;


namespace ConApp4s89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int total1 = num1 * 50;
            Console.WriteLine(num1 + " times 50 is " + total1);
            Console.WriteLine("Enter a number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            int total2 = num2 + 25;
            Console.WriteLine(num2 + " plus 25 is " + total2);
            Console.WriteLine("Enter a number");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            decimal total3 = Decimal.Divide(num3, 12.5m);
            Console.WriteLine(num3 + " divided by 12.5 is " + total3);
            Console.WriteLine("Enter a number");
            int num4 = Convert.ToInt16(Console.ReadLine());
            bool result = num4 > 50;
            Console.WriteLine(num4 + " geater than 50 " + result);
            Console.WriteLine("Enter a number");
            int num5 = Convert.ToInt16(Console.ReadLine());
            int remainder = num5 % 7;
            Console.WriteLine(num5 + " divided by 7 has a remainder of " + remainder);
            Console.ReadLine();

        }
    }
}
