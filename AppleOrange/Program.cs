using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            string[] ab = Console.ReadLine().Split();
            int a = Convert.ToInt32(ab[0]);
            int b = Convert.ToInt32(ab[1]);
            string[] mn = Console.ReadLine().Split();
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);
            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        private static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleSum = 0, orangeSum = 0, appleCount = 0, orangeCount = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                appleSum = a + apples[i];
                if (appleSum >= s && appleSum <= t)
                {
                    appleCount++;
                }
            }
            Console.WriteLine(appleCount);

            for (int j = 0; j < oranges.Length; j++)
            {
                orangeSum = b + oranges[j];
                if (orangeSum >= s && orangeSum <= t)
                {
                    orangeCount++;
                }
            }
            Console.WriteLine(orangeCount);
        }
    }
}
