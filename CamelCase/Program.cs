using System;
using System.Text;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = camelCase(input);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        //Method 1
        public static int camelCase(string s)
        {
            int res = 0;

            foreach (var item in s)
            {
                if (char.IsUpper(item))
                {
                    res++;
                }
            }
            return res + 1;
        }

        //Method 2
        public static int camelCase1(string s)
        {
            int res = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var item in s)
            {
                if (char.IsUpper(item))
                {
                    sb.Append("\n");
                }
            }
            res = sb.Length;
            return res + 1;
        }

    }
}
