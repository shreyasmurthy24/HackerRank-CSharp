using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var count = 0;
            var max = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    count++;
                    if (count > max)
                    { max = count; }
                }
                else
                { count = 0; }
                n = n / 2;
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
