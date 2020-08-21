using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to manuipiate");
            int num = Convert.ToInt32(Console.ReadLine());
            
            MyMath math = new MyMath();
            Console.WriteLine(num + " added to self is " + math.plus(num));
            Console.WriteLine(num + " subtracted from 100 is " + math.minus(num));
            Console.WriteLine(num + " times to self is " + math.times(num));
            Console.ReadLine();
        }
    }
}
