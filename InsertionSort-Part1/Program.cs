using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            insertionSort1(n, arr);

            Console.ReadKey();
        }

        /* *
            5
            2 4 6 8 3

            2 4 6 8 8 
            2 4 6 6 8 
            2 4 4 6 8 
            2 3 4 6 8 
         * */
        private static void insertionSort1(int n, int[] arr)
        {
            int number = arr[n - 1];

            for (int i = n -1; i >= 0; i--)
            {
                if (arr[i] > number)
                {
                    arr[i + 1] = arr[i];

                    foreach (var item in arr)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    if (arr[i] < number)
                    {
                        arr[i + 1] = number;
                        foreach (var item in arr)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    }
                }
            }
            if (number < arr[0])
            {
                arr[0] = number;
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
