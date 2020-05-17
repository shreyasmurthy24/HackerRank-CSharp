using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            //phoneBook.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            //phoneBook.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            //phoneBook.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));

            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //string s3 = Console.ReadLine();
            //if (phoneBook.ContainsKey(s1))
            //{
            //    Console.WriteLine(s1 + "=" + phoneBook[s1]);
            //}
            //else { Console.WriteLine("Not found"); }

            //if (phoneBook.ContainsKey(s2))
            //{
            //    Console.WriteLine(s2 + "=" + phoneBook[s2]);
            //}
            //else { Console.WriteLine("Not found"); }

            //if (phoneBook.ContainsKey(s3))
            //{
            //    Console.WriteLine(s3 + "=" + phoneBook[s3]);
            //}
            //else { Console.WriteLine("Not found"); }

            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Split(' ');
                phoneBook.Add(s[0], s[1]);
            }
            string soap = string.Empty;
            for (int i = 0; i < n; i++)
            {
                soap = Console.ReadLine();
                if (phoneBook.ContainsKey(soap))
                {
                    Console.WriteLine(soap + "=" + phoneBook[soap]);
                }
            }

            //int n = Convert.ToInt32(Console.ReadLine());
            //var d = new Dictionary<string, string>();
            //for (int i = 0; i < n; i++)
            //{
            //    var s = Console.ReadLine().Split(' ');
            //    d.Add(s[0], s[1]);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    var s = Console.ReadLine();
            //    if (d.ContainsKey(s))
            //    {
            //        Console.WriteLine(s + "=" + d[s]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not found");
            //    }
            //}


            Console.ReadKey();
        }
    }
}
