using System;

namespace BreakingRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int[] result = breakingRecords(scores);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadLine();
        }

        private static int[] breakingRecords(int[] scores)
        {
            int countMin = 0, countMax = 0;
            int[] res = new int[2];
            int highest = scores[0], lowest = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < lowest)
                {
                    lowest = scores[i];
                    countMin++;
                    res[1] = countMin;
                }

                if (scores[i] > highest)
                {
                    highest = scores[i];
                    countMax++;
                    res[0] = countMax;
                }
            }
           
            return res;
        }
    }
}
