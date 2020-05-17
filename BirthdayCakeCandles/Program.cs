using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 1, 3 };
            int op = birthdayCakeCandles(arr);
            Console.WriteLine(op);
            Console.ReadKey();
        }

        private static int birthdayCakeCandles(int[] ar)
        {
            var dict = new Dictionary<int, int>();
            int count = 0;
            foreach (var value in ar)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                    count += 1;
                }
                else
                { dict[value] = 1; }
            }
            int num = dict.Values.Max();

            return num;
        }
    }
}
