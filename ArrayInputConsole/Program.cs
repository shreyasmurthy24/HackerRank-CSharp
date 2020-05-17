using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInputConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            //Array
            int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), temp => Convert.ToInt32(temp));

            //List
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(temp => Convert.ToInt32(temp)).ToList();
        }
    }
}
