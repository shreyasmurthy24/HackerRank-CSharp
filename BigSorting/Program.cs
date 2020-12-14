using System;
using System.Linq;
using System.Numerics;

namespace BigSorting
{
    class Program
    {
        //I've implemented a new keywork "BigInteger" that derives from System.Numerics namespace.
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
            BigInteger[] numbers = Array.ConvertAll(unsorted, s => BigInteger.Parse(s));

            for (int i = 0; i <= numbers.Count() - 1; i++)
            {
                for (int j = 0; j <= numbers.Count() - 1; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        BigInteger temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            string[] sorted = numbers.Select(x => x.ToString()).ToArray();

            //Return a string[]. Converting a string directly as a string[] in return statement.
            //string sorted = string.Join(",", numbers);
            //return new[] { sorted };

            return sorted;
        }
    }
}
