using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting a string[]
            string[] str = new string[] { "Laptop", "Mouse", "Keyboard", "Charger" };
            foreach (var item in str)
            {
                Console.WriteLine("Input: " + item);
            }

            Console.WriteLine();
            Array.Sort(str);

            foreach (var item in str)
            {
                Console.WriteLine("Output: " + item);
            }

            Console.WriteLine();

            //Sorting a char[]
            char[] ch = { 'S', 'A', 'K', 'B', 'M', 'T'};
            Console.WriteLine("Input : " +new string(ch));

            Array.Sort<char>(ch);
            Console.WriteLine("Sorted Char Array : " + new string(ch));

            Console.ReadKey();
        }
    }
}
