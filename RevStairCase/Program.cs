using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevStairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s0 = "#"; int n = 6;
            for (int i = 0; i < n; i++)
            {
                //string s = s0 + s1;
                Console.WriteLine(s0.PadLeft(n));
                s0 += "#";
            }
            Console.ReadKey();
        }
    }
}
