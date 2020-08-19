using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int l=1;
            int i;
            bool lp=true;
            while(lp)
            {
                for (i = 0; i < l; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                l++;
                if (l == 5) lp = false;
            }
            do
            {
                for (i = 0; i < l; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                l--;
                if (l == 0) lp = true;
            } while (!lp);
            Console.ReadLine();
        }
    }
}
