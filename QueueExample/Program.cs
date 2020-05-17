using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);

            foreach (Object obj in myQueue)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Elements count in the queue = " + myQueue.Count);
            Console.WriteLine();

            myQueue.Dequeue();

            foreach (Object obj in myQueue)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
