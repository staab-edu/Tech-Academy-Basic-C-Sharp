using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            //string[] things = { "Blue", "Berry", "Fruit", "Juice" };
            //int l;
            //Console.WriteLine("Enter some text");
            //string str = Console.ReadLine();
            //for(l = 0; l < 4; l++) 
            //{
            //    things[l] = things[l] + " " + str;
            //}
            //for (l = 0; l < 4; l++)
            //{
            //    Console.WriteLine(things[l]);
            //}

            // Part 2
            // Part 3
            // Part 4
            int l;
            for(l=1; l < 10; l++)
            {
                Console.WriteLine("Line # " + (l*10).ToString());
            }


            Console.ReadLine();
        }
    }
}
