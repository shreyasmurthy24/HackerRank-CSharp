using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int res = Anagrams(a, b);
        }

        private static int Anagrams(string a, string b)
        {
            int count = 0;

            char[] sa = a.ToCharArray();
            char[] sb = b.ToCharArray();

            Array.Sort(sa);
            Array.Sort(sb);

            for (int i = 0; i < sa.Length; i++)
            {
                for (int j = 0; j < sb.Length; j++)
                {
                    if (sa[i] == sb[j])
                    {

                    }
                }
            }


            return count;
        }

    }
}
