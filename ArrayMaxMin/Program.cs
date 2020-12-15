using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 10, 2, 1, 3, 7, 4, 8, 6, 9 };

            //Find min
            int minVal = 0; int maxVal = 0;
            minVal = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (minVal > arr[i])
                {
                    minVal = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxVal < arr[i])
                {
                    maxVal = arr[i];
                }
            }

            Console.WriteLine("Max val : " + maxVal);
            Console.WriteLine("Min val : " + minVal);
            Console.ReadKey();
        }
    }
}
