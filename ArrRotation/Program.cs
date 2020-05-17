using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = Convert.ToInt32(Console.ReadLine());
            int n =Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < d; i++)
                leftRotatebyOne(arr, n);

            Console.ReadKey();
        }
        
        static void leftRotatebyOne(int[] arr, int n)
        {
            int i, temp = arr[0];
            for (i = 0; i < n - 1; i++)
                arr[i] = arr[i + 1];

            arr[i] = temp;
        }

        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
        }

    }
}
