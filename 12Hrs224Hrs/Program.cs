using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Hrs224Hrs
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTime = "07:05:45PM";
            DateTime time;
            if (DateTime.TryParseExact(strTime, "hh:mm:sstt", null, System.Globalization.DateTimeStyles.None, out time))
            {
                string s = time.ToString("HH\\:mm\\:ss");
                Console.WriteLine("Parsed \"{0}\" as {1:HH\\:mm\\:ss}", strTime, time);
            }
            else
            {
                Console.WriteLine("Could not parse \"{0}\" as a DateTime", strTime);
            }
            Console.ReadLine();
        }
    }
}

//double tip = (double)tip_percent / 100;
//double tax = (double)tax_percent / 100;
//double tip1 = meal_cost * tip;
//double tax1 = meal_cost * tax;
//int meal = Convert.ToInt32(meal_cost + tip1 + tax1);

//Console.WriteLine(meal);

//int i2; double d2; double d3; string s1;
////Console.WriteLine("Enter an interger variable : ");
//i2 = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter an double value : ");
//d2 = double.Parse(Console.ReadLine());
////Console.WriteLine("Enter an string variable : ");
//s1 = Console.ReadLine();

//int intSum = i + i2;

//double db = (double)d + d2;
//string concat = s + s1;
//Console.WriteLine(intSum);
//Console.WriteLine("{0:F1}", db);
//Console.WriteLine(concat);

