using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,12,13,23,34,4,5,3,66,44,77,15 };            
            int key = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == key)
            //    {
            //        count = 2;
            //        Console.WriteLine(key + " is present");
            //    }
            //    else { count = 1; }
            //}
            //if (count == 1 && count != 2)
            //{
            //    Console.WriteLine(key + " is not present.");
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    Console.WriteLine("Found.");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
