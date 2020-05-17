using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrDiagonalDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<List<int>> arr = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().Trim().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagDiff(arr);

        }

        private static int diagDiff(List<List<int>> arr)
        {
            int sum = 0, n, m = 0, k = 0, l = 0;
            int[,] arr1 = new int[,] { };

            //arr1 = arr.Select(a => a.ToArray()).ToArray();

            m = arr.Count;
            //foreach (var item in arr)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    m = m - 1;
                    for (int j = 0; j < arr.Count; j++)
                    {
                        if (j == m)
                        {
                            sum = sum + arr1[i,j];
                        }
                    }
                }
            }
            return sum;
        }
    }
}
