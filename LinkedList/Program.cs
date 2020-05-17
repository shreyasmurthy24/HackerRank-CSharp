using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.Print();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(10);
            node.next = new Node(2);
            node.next.next = new Node(14);
            node.next.next.next = new Node(5);
            node.Print();
        }
    }
}
