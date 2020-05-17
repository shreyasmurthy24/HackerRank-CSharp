using System;

namespace MarkAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
            int res = maxToys(prices, k);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private static int maxToys(int[] prices, int k)
        {
            Array.Sort(prices);
            int sum = 0; int count = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] <= k)
                {
                    k -= prices[i];
                    count++;
                }
            }
            return count;
        }
    }
}
