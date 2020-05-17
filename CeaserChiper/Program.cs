using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserChiper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            string res = ceaserChiper(s, k);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private static string ceaserChiper(string s, int k)
        {
            s = s.ToLower();
            string[] s1 = s.Select(x => x.ToString()).ToArray();
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            string[] arrAlpha = alpha.Select(y => y.ToString()).ToArray();

            for (int i = 0; i < s1.Length; i++)
            {

            }

            return s;


        }
    }
}
