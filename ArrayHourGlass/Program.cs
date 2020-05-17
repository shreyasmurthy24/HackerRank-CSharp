using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHourGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                    + arr[i + 1][j + 1] +
                      arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    //if (sum > max) { max = sum; }
                    max = Math.Max(max, sum);
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
