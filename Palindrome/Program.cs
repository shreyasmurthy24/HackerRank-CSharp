using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            char[] ch = word.ToArray();
            int len = ch.Length;
            char[] ch1 = new char[len];
            Array.Copy(ch, ch1, len);
            Array.Reverse(ch1);
            if (ch.SequenceEqual(ch1))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not");
            }

            Console.ReadKey();
        }
    }
}
