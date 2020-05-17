using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,5};
            int array = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                array += arr[i];
            }
            Console.WriteLine(array);
            Console.Read();
        }
    }
}
