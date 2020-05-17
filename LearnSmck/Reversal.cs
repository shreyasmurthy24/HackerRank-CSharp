using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSmck
{
    class Reversal
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseDirect("String")); //OR
            string rev = ReversalString("String");  //OR
            string s1 = RevStr("String");
            Console.WriteLine(rev);
        }

        private static string ReverseDirect(string s)
        {
            char[] c = new char[s.Length];
            int j = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                c[j++] = s[i];
            }

            return new string(c);
        }

        private static string ReversalString(string s)
        {
            string rev = string.Empty;
            foreach (char item in s)
            {
                rev = item + rev;
            }
            return rev;
        }

        private static string RevStr(string s)
        {
            char[] c = s.ToArray();
            Array.Reverse(c);
            string s1 = new string(c);
            return s1;
        }
    }
}
