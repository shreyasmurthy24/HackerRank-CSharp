using System;

namespace ArrReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int n = Convert.ToInt32(Console.ReadLine());

            int[] res = ArrRev(arr, n);
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
            Console.ReadKey();
        }

        public static int[] ArrRev(int[] arr, int n)
        {
            int size = arr.Length;
            int[] rot_arr = new int[size];
            int i = 0; int rot_index = n;

            while (rot_index < size)
            {
                rot_arr[i] = arr[rot_index];
                i++;
                rot_index++;
            }

            rot_index = 0;
            while (rot_index < n)
            {
                rot_arr[i] = arr[rot_index];
                i++;
                rot_index++;
            }

            return rot_arr;



            //int[] rotate = new int[arr.Length];

            //    for (int i = 0; i < arr.Length - n; i++)
            //    {
            //        rotate[i] = arr[i + n];
            //    }

            //int len = rotate.Length;
            //for (int i = 0; i <= n; i++)
            //{
            //    rotate[len - (1-0)] = arr[i];
            //}

        }
    }
}
