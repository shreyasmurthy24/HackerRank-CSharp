using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            string s = time.ToString("HH\\:mm\\:ss");
            Console.WriteLine(s);
        }
    }
}
