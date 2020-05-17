using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrRanking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            int count = 0; int count2 = 0;
            int check = 0; int check2 = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < scores[i++])
                {
                    check = scores[i]; //10
                    count++;
                }
            }

            for (int j = 0; j < scores.Length; j++)
            {
                if (scores[j] < scores[j++])
                {
                    check2 = scores[j];
                    count2++;
                }
            }

            Console.WriteLine(count + " " + count2);
            Console.ReadKey();
        }
    }
}
