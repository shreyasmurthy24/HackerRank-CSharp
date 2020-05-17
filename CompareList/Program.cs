using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(5);
            a.Add(6);
            a.Add(7);

            List<int> b = new List<int>();
            b.Add(3);
            b.Add(6);
            b.Add(10);

            List<int> c = new List<int>();
            int sum1 = 0;
            int sum2 = 0;
            int i, j = 0;

            for (i = 0; i < a.Count; i++,j++)
            {
                if (a[i] == b[j])
                {

                }
                else if (a[i] > b[j])
                {
                    sum1 += 1;
                }
                else if (a[i] < b[j])
                {
                    sum2 += 1;
                }

            }

            c.Add(sum1);
            c.Add(sum2);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
