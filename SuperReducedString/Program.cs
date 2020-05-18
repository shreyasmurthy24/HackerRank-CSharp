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
            string s = "baab";
            //string s = "abcdefgh";
            string res = superReducedString(s);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static string superReducedString(string s)
        {
            string output = string.Empty;
            
            char[] ch = s.ToCharArray();

            for (int i = 0; i < ch.Length - 1; i++)
            {
                var lst = s.ToList();

                if (ch[i] == ch[i + 1])
                {
                    var val = ch[i];
                    var val1 = ch[i +1];
                    lst.Remove(val);
                    lst.Remove(val1);
                    ch = lst.ToArray();
                    s = string.Join(",", lst.ToArray());
                    s = s.Replace(",", "");
                }
            }

            for (int i = 0; i < ch.Length; i++)
            {
                var lst = s.ToList();

                if (ch[i] == ch[i + 1])
                {
                    var val = ch[i];
                    var val1 = ch[i + 1];
                    lst.Remove(val);
                    lst.Remove(val1);
                    ch = lst.ToArray();
                    s = string.Join(",", lst.ToArray());
                    s = s.Replace(",", "");
                }
            }

            if (ch.Length == 0)
            {
                output = "Empty string";
            }
            else
            {
                output = s;
            }

            return output;
        }
    }
}
