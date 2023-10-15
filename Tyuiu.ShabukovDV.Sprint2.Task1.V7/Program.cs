using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.Sprint2.Task1.V7.Lib;

namespace Tyuiu.ShabukovDV.Sprint2.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 195;
            int b = 16;
            int c = 14;
            int d = 45;

            bool[] res = new bool[6];

            res[0] = a == 195;
            res[1] = b != 16;
            res[2] = c < 14;
            res[3] = d > 45;
            res[4] = a <= 195;
            res[5] = b >= 16;

            
        }
    }
}
