using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "AAABBB";
            char[] ch = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < ch.Length-1; i++)
            {
                if (ch[i] == ch[i+1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //List<string> lst = s.Select(c => c.ToString()).ToList();
            //string s1 = string.Empty;

            //foreach (var item in lst)
            //{
            //    s1 = item;
            //    string s2 = item;
            //}

            Console.ReadKey();
        }
    }
}
