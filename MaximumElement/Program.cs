using System;
using System.Collections;
using System.Collections.Generic;

namespace MaximumElement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            int type = 0; int x = 0;

            int countVal = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < countVal; k++)
            {
                string[] num = Console.ReadLine().Split(' ');

                if (num.Length == 1)
                {
                    type = Convert.ToInt32(num[0]);
                }
                else
                {
                    type = Convert.ToInt32(num[0]);
                    x = Convert.ToInt32(num[1]);
                }

                if (type == 1)
                {
                    myStack.Push(x);
                }
                else if (type == 2)
                {
                    myStack.Pop();
                }
                else if (type == 3)
                {
                    int[] arr = myStack.ToArray();
                    if (arr.Length == 0)
                    {

                    }
                    else
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] < arr[i + 1])
                            {
                                Console.WriteLine(arr[i + 1]);
                            }
                            else
                            {
                                Console.WriteLine(arr[i]);
                            }
                        }
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
