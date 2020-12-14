using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "qwertyuiopasdfghjklzxcvbnm";
            Console.WriteLine("Input: " + str);

            Console.WriteLine("Method 1 - LINQ");
            Console.WriteLine(string.Concat(str.OrderBy(s => s)));

            Console.WriteLine();

            Console.WriteLine("Method 2 - CHAR ARRAY");
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            Console.WriteLine(ch);

            Console.ReadKey();
        }
    }
}
