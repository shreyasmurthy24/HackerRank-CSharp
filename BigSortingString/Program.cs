using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSortingString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] unsorted = new string[n];

            for (int i = 0; i < n; i++)
            {
                string unsortedItem = Console.ReadLine();
                unsorted[i] = unsortedItem;
            }

            string[] result = bigSorted(unsorted);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        }

        private static string[] bigSorted(string[] unsorted)
        {
            int len = unsorted.Length;
            for (int i = 0; i < len - 1; i++)
            {
                
            }

            return null;
        }
    }
}
