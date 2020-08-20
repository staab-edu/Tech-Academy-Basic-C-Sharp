using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 concat string to array
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

            // Part 2 Loop problem
            // Part 3 Loop fixed
            // Part 4 Loop <
            // Part 5 loop <=
            //int l;
            //for(l=1; l <= 10; l++)
            //{
            //    Console.WriteLine("Line # " + (l*10).ToString());
            //}

            // Part 6 list search
            // Part 7 add not found
            // Part 8 add break
            // Part 9 Duplicate items/multiple matches
            // Part 10 add not in list
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Yellow");
            colors.Add("Green");
            colors.Add("Purple");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("Purple");
            List<string> tmpclr = new List<string>();
            //string str;

            //Console.WriteLine("Enter a color");
            //str= Console.ReadLine();
            foreach (string color in colors) 
            {
                if(tmpclr.IndexOf(color) > 0)
                {
                    Console.WriteLine(color + " seen before.");
                }
                else
                {
                    Console.WriteLine(color + " not seen before");
                    tmpclr.Add(color);
                }
            }

            //int i;
            //bool found=false;
            //for (i = 0; i < color.Count; i++)
            //    if (color[i].ToLower() == str.ToLower()) 
            //    {
            //        Console.WriteLine(str + " found at " + i);
            //        found=true;
            //    }
            //if (!found)
            //    Console.WriteLine(str + " not in list");

            Console.ReadLine();
        }
    }
}
