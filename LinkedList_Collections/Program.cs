using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("One");
            list.AddLast("Two");
            list.AddLast("Three");
            list.AddLast("Four");
            list.AddLast("Example");
            list.AddLast("Five");
            list.AddLast("Six");
            list.AddBefore(list.Last.Previous.Previous, "Added before");


            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("----------");

            //Remove
            Console.WriteLine("----Remove only");
            list.Remove(list.First.Next.Next.Next);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            Console.WriteLine("----Remove Example");
            list.Remove("Example");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            Console.WriteLine("----Remove last");
            list.RemoveLast();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");
            Console.WriteLine("Check if an item is present in LL");

            if (list.Contains("Two") == true)
            {
                Console.WriteLine("Two is present..");
            }
            else
            {
                Console.WriteLine("Two is not present..");
            }

            Console.ReadKey();
        }
    }
}
