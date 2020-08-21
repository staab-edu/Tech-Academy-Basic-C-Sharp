using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class MyMath
    {
        public int plus(int num)
        {
            num = num + num;
            return num;
        }

        public int minus(int num)
        {
            num = 100 - num;
            return num;
        }

        public int times(int num)
        {
            num = num * num;
            return num;
        }
    }
}
