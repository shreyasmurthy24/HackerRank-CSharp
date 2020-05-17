using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1900;
            bool checkIfLeapYear = false;
            int leapYearSum = 0; string output = string.Empty;
            int nonLeapYearSum = 0;

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                leapYearSum = 244;
                int day = 256 - 244;
                output = day + "." + "09" + "." + year;
                Console.WriteLine(output);
            }
            else
            {
                nonLeapYearSum = 243;
                int day = 256 - 243;
                output = day + "." + "09" + "." + year;
                Console.WriteLine(output);
            }


            //if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            //{
            //    leapYearSum = 244;
            //    int day = 256 - 244;
            //    output = day + "." + "09" + "." + year;
            //    Console.WriteLine(output);                        
            //}
            //else// if(checkIfLeapYear == false)
            //{
            //    nonLeapYearSum = 243;
            //    int day = 256 - 243;
            //    output = day + "." + "09" + "." + year;
            //    Console.WriteLine(output);
            //}
            Console.ReadKey();
        }
    }
}