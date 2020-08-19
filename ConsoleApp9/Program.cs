using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = "World! ";
            string str3 = "Its 2020.";
            string msg;
            string umsg;
            msg = str1 + str2 + str3;
            Console.WriteLine(msg);
            umsg = msg.ToUpper();
            Console.WriteLine(umsg);
            StringBuilder strb = new StringBuilder();
            strb.Append("This is a test. ");
            strb.Append("This paragraph was made with StringBuilder. ");
            strb.AppendLine("StringBuilder allows a string to change.");

            Console.WriteLine(strb);
            Console.ReadLine();
        }
    }
}
