using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nSeriesGeometricProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, r = 2, N = 4;
            int S = arithmeticProgression(a, r, N);
            Console.WriteLine(S);
            Console.ReadKey();
        }

        //Geometric Progression, goes with the formula : a * r to the power of (N - 1)
        private static int arithmeticProgression(int a, int r, int N)
        {
            return a * (int)(Math.Pow(r, N - 1));
        }
    }
}
