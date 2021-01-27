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

            //int[] result = BigSorting(unsorted);

            Array.Sort(unsorted, (string a, string b) =>
            {
                if (a.Length == b.Length)
                    return string.Compare(a, b, StringComparison.Ordinal);
                return a.Length - b.Length;
            });

            Console.WriteLine(string.Join("\n", unsorted));
            Console.ReadKey();
        }

        //private static int[] BigSorting(string[] unsorted)
        //{
        //    Array.Sort(unsorted, (string a, string b) => {
        //        if (a.Length == b.Length)
        //            return string.Compare(a, b, StringComparison.Ordinal);
        //        return a.Length - b.Length;
        //    });
        //}

        /*
         31415926535897932384626433832795, 1, 3, 10, 3, 5
        */

    }
}
