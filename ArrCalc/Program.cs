using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,4,5,3,2};
            int arrayLen = arr.Length;

            long min = arr.Min();
            long max = arr.Max();
            long minSum = 0;
            long maxSum = 0;
            long sum = 0;
            for (int i = 0; i < arrayLen; i++)
            {
                 sum += arr[i];
            }
                
            minSum = sum - max;
            maxSum = sum - min;
            Console.WriteLine(minSum + " " + maxSum);
            Console.ReadKey();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] != max)
            //    {
            //        //maxArray.Prepend(max);
            //        minSum =minSum + arr[i];
            //    }
            //    if (arr[i] != min)
            //    {
            //        //maxSum = maxSum + arr[i];
            //        maxSum = Convert.ToInt32(maxSum) + Convert.ToInt32(arr[i]);
            //    }
            //}
            //Console.Write(minSum + " " + maxSum);
            //Console.ReadKey();
        }
    }
}
