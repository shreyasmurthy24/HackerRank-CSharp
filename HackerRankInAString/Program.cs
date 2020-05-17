using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string s = Console.ReadLine();
                string res = hackerrankinastring(s);
                Console.WriteLine(res);
            }

        }

        private static string hackerrankinastring(string str)
        {
            string word = "hackerrank";
            str = String.Concat(str.OrderBy(b => b));
            word = String.Concat(word.OrderBy(c => c));
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == word[count]) count++;

                if (count == 10)
                {
                    return "YES";
                }
            }
             return "NO";
        }
    }
}
