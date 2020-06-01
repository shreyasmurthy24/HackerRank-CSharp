using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nSeriesArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, d = 3, N = 10;
            int S = arithmeticProgression(a, d, N);
            Console.WriteLine(S);
            Console.ReadKey();
        }

        //Arithmetic Progression, goes with the formula : a + (N - 1)d
        private static int arithmeticProgression(int a, int d, int N)
        {
           return (a + (N - 1) * d);
        }
    }
}
