using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = MarsExploration(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int MarsExploration(string s)
        {
            string sos = "SOS";
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != sos[i % 3]) 
                {
                    count++;
                }
            }
            return count;
        }
    }
}
