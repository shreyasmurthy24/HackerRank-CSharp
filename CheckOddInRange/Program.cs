using System;
using System.Collections.Generic;

namespace CheckOddInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 90;
            int r = 97;
            findOdd(l, r);
        }

        private static void findOdd(int l, int r)
        {
            List<int> lst = new List<int>();
            int count = r - l;
            int[] arr = new int[count];
            int val = 0;
            for (int i = l; i < r; i++)
            {
                while (i % 2 != 0)
                {
                    arr[val] = i;
                    val++;
                    break;
                }
            }

            var list = new List<int>(arr);
            foreach (var item in list)
            {
                while (item != 0)
                {
                    lst.Add(item);
                    break;
                }
            }
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
