using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrDiagSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0, n, m = 0;
            int[,] arr1 = new int[50, 50];


            Console.Write("\n\nFind the sum of left diagonals of a matrix :\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            // calculate the sum of left diagonals
            for (i = 0; i < n; i++)
            {
                m = m - 1;
                for (j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        sum = sum + arr1[i, j];
                    }
                }
            }
            Console.Write("Addition of the  left Diagonal elements is :{0}\n", sum);
            Console.ReadKey();
        }
    }
}
