using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);

            foreach (Object obj in myStack)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("The number of elements in a stack are : " + myStack.Count);
            Console.WriteLine("Element in location 4 is : " + myStack.Contains(40));
            Console.WriteLine("Element at the top of the stack : " + myStack.Peek());

            myStack.Pop();
            foreach (Object obj in myStack)
            {
                Console.WriteLine("Queue after deletion - " + obj);
            }

        }
    }
}
