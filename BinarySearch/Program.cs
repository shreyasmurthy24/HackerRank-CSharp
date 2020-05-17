using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] array = new int[] { 11, 22, 4, 5, 17, 28, 9, 10, 12, 14, 15, 20, 25 };
            //Array.Sort(array);
            //linearSearch(array, 25);
            int key = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(BinarySearch(array, key));
            Console.ReadKey();
        }

        private static void linearSearch(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine("Value in present in array");
                }
                //else { Console.WriteLine("Not present"); }
            }
        }

        private static int BinarySearch(int[] arr, int key)
        {
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    max = mid - 1;
                }
                else { min = mid + 1; }
            }
            return 0;
        }
    }
}
