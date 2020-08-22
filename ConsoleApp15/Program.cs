using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter two integer to manuipiate");
            Console.WriteLine("One per line (second can be blank)");
            int num1 = Convert.ToInt32(Console.ReadLine());
            string inp = Console.ReadLine();

            MyMath math = new MyMath();
            if (inp != "")
            {
                int num2 = Convert.ToInt32(inp);
                num = math.times(num1, num2);
                Console.WriteLine("{0} times {1} = {2}", num1, num2, num);
            } else
            {
                num = math.times(num1);
                Console.WriteLine("{0} times 10 = {1}", num1,num);
            }
            
            Console.ReadLine();
        }
    }
}
