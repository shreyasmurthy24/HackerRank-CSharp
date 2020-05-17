using System;
using System.Collections.Generic;
using System.Linq;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Trim().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
            Console.ReadKey();
        }

        private static void bonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            int bactual = 0;
            foreach (int items in bill)
            {
                bactual += items;
            }

            if (b - (bactual/2) == 0)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                int charged = b - (bactual/2);
                Console.WriteLine(charged);
            }
        }
    }
}
