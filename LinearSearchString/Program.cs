using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[] { "word", "word1", "word2", "word3", "word4" };
            string key = Console.ReadLine();
            for (int i = 0; i < strArr.Length; i++)
            {
                if (key == strArr[i])
                {
                    Console.WriteLine(key + " is present.");
                }
            }
            Console.ReadKey();
        }
    }
}
