using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=)
//последовательность можно чередовать, но использовать один раз в выражении
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)
//а также арифметических выражений, которая вернет логическую последовательность(массив): (True, False, False, False, True, False)
//при a = 195, b = 16, c = 14, d = 45

namespace Tyuiu.ShabukovDV.Sprint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = a == 195;
            res[1] = b != 16;
            res[2] = c < 14;
            res[3] = d > 45;
            res[4] = a <= 195;
            res[5] = b >= 16;

            return res;
        }
       
 
    }
}
