using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -4, -3, 9, 0, 4, 1 };
            //int val1 = 0; int val2 = 0; int val3 = 0;
            int count1 = 0; int count2 = 0; int count3 = 0;
            decimal cal1, cal2, cal3 = 0.0M;
            int len = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count1 += 1;
                    //val1 += 1;
                }
                else if (arr[i] > 0)
                {
                    count2 += 1;
                    //val2 += 1;
                }
                else if (arr[i] < 0)
                {
                    count3 += 1;
                    //val3 += 1;
                }                               
            }

            cal1 = (decimal)count1/len;
            cal2 = (decimal)count2/len;
            cal3 = (decimal)count3/len;
            Console.WriteLine(Decimal.Round(cal1, 6));
            Console.WriteLine(cal2);
            Console.WriteLine(cal3);
        }
    }
}
