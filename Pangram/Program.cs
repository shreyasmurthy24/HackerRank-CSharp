using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "We promptly judged antique ivory buckles for the next prize";
            string res = pangram(word);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private static string pangram(string word)
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            word = word.ToLower();
            int count = 0;
            for (int i = 0; i < alpha.Length; i++)
            {
                if (word.Contains(alpha[i]))
                {
                    count++;
                }
            }
            if (count == 26)
            {
                return "pangram";
            }

            return "not pangram";
        }
    }
}
