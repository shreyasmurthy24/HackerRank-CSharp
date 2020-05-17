using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 3, 2};

            int[] res = ArrRev(arr);
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
            Console.ReadKey();
        }

        public static int[] ArrRev(int[] arr)
        {
            int[] rev = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length-1; i > 0; i--)
            {
                rev[j] = arr[i];
                j++;
            }

            rev[rev.Length - 1] = arr[0];
            return rev;
        }
    }
}
