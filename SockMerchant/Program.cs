using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int sockMerchant(int n, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                int key = ar[i];
                for (int j = 0; j < ar.Length - 1; j++)
                {
                    if (key == ar[j])
                    {
                        count++;
                        int val = count % 2;
                        if (val == 0)
                        {
                            break;
                        }
                    }
                }
            }
            
            return count;

        }
    }
}
