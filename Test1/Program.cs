using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ACount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> A = new List<int>();

            for (int i = 0; i < ACount; i++)
            {
                int AItem = Convert.ToInt32(Console.ReadLine().Trim());
                A.Add(AItem);
            }

            string result = plusMult(A);
        }

        public static string plusMult(List<int> A)
        {
            int a0 = 0; int a2 = 0; int a4 = 0; int a6 = 0; int a8 = 0;
            int a1 = 0; int a3 = 0; int a5 = 0; int a7 = 0; int a9 = 0;
            int a = 0;
            int b = 0;
            int Reven = 0; int Rodd = 0; string retVal = string.Empty;
            //Reven = (((A0 * A2) + A4) * A6) + A8;
            //Reven = Reven % 2;
            //Console.WriteLine(Reven);

            //Rodd = (((A1 * A3) + A5) * A7) + A9;
            //Rodd = Rodd % 2;
            //Console.WriteLine(Rodd);
            int j = 0; int k = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (i % 2 == 0)
                {
                    A[j] = A[i];
                    j++;

                }
                else
                {
                    A[k] = A[i];
                    k++;
                }
            }
            Reven = (((A[j] * A[j]) + A4) * A6) + A8;

            //Reven = (((A0 * A2) + A4) * A6) + A8;
            //Reven = Reven % 2;
            //Console.WriteLine(Reven);

            //Rodd = (((A1 * A3) + A5) * A7) + A9;
            //Rodd = Rodd % 2;
            //Console.WriteLine(Rodd);





            if (Rodd > Reven)
            {
                retVal = "ODD";
            }
            else if (Reven > Rodd)
            {
                retVal = "EVEN";
            }
            else if (Rodd == Reven)
            {
                retVal = "NEUTRAL";
            }

            return retVal;

        }
    }
}
