using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class NumManip
    {
        public int mymanip(int num)
        {
            num = num + 20;
            return num;
        }
        public int mymanip(decimal num)
        {
            num = num * 10;
            return Decimal.ToInt32(num);
        }
        public int mymanip(string snum)
        {
            int num;
            num = Convert.ToInt32(snum) - 5;
            return num;
        }
    }
}
