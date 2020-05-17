using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x1vx1x2vx2 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(x1vx1x2vx2[0]);
            int v1 = Convert.ToInt32(x1vx1x2vx2[1]);
            int x2 = Convert.ToInt32(x1vx1x2vx2[2]);
            int v2 = Convert.ToInt32(x1vx1x2vx2[3]);
            string result = kangroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }

        private static string kangroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2)
            {
                int res = (x1 - x2) % (v2 - v1);
                if (res == 0)
                {
                    return "YES";
                }
            }
            return "N0";
        }
    }
}
