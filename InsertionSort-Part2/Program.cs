using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            insertionSort2(n, arr);

            Console.ReadKey();
        }

        /*
        I/P 1 4 3 5 6 2

            1 4 3 5 6 2 
            1 3 4 5 6 2 
            1 3 4 5 6 2 
            1 3 4 5 6 2 
            1 2 3 4 5 6 
        */

        private static void insertionSort2(int n, int[] arr)
        {
            for (int i =0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    foreach (var item in arr)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = i; j >= 0; j--)
                    {
                        if (arr[i + 1] > arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                            foreach (var item in arr)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            int temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                            foreach (var item in arr)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
