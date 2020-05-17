using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[] { };
            List<string> lst = new List<string>();
            int inputCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                lst.Add(Console.ReadLine());

            }
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
