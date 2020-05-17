using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            string[] dm = Console.ReadLine().Trim().Split(' ');
            int d = Convert.ToInt32(dm[0]);
            int m = Convert.ToInt32(dm[1]);
            int res = birthdayChocolate(s,d,m);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private static int birthdayChocolate(List<int> s, int d, int m)
        {
            int result = 0;
            int val = 0;
            foreach (var item in s)
            {
                result = result + item;
                if (result == d)
                {
                    val++;
                }
            }


            return result;
        }

    }
}
