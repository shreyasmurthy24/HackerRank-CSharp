using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = new CultureInfo("fr-FR");

            DateTime returnedDate = DateTime.Parse(Console.ReadLine(), provider);
            DateTime expectedDate = DateTime.Parse(Console.ReadLine(), provider);

            if (returnedDate < expectedDate)
            {
                Console.WriteLine(0);
            }
            else if (returnedDate.Year > expectedDate.Year)
            {
                Console.WriteLine(10000);
            }
            else if (returnedDate.Month > expectedDate.Month)
            {
                Console.WriteLine((returnedDate.Month - expectedDate.Month) * 500);
            }
            else if (returnedDate.Day > expectedDate.Day)
            {
                Console.WriteLine((returnedDate.Day - expectedDate.Day) * 15);
            }

            Console.ReadKey();
        }
    }
}
