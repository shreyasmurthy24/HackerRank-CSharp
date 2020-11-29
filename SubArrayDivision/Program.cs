using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArrayDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            string[] dm = Console.ReadLine().TrimEnd().Split(' ');
            int d = Convert.ToInt32(dm[0]);
            int m = Convert.ToInt32(dm[1]);

            int result = birthdays(s, d, m);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int birthdays(List<int> s, int d, int m)
        {
            int counter = 0;
            int temp = 0;
            foreach (var item in s)
            {
                temp += item;
                if ((temp + item) == d )
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
