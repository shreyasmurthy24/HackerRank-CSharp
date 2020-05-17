using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aaabbccddd";
            string res = superReducedString(s);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static string superReducedString(string s)
        {
            string output = string.Empty;

            char[] ch = s.ToCharArray();
                    

            for (int i = 0; i < ch.Length -1; i++)
            {
                if (ch[i] == ch[i+1])
                {
                   ch = new string(ch).Remove(0,1).ToCharArray();
                }
            }

            if (ch.Length == 0)
            {
                output = "Empty string";
            }
            else
            {
                output = new string(ch);
            }

            return output;
        }
    }
}
