using System;
using LinkedList.Class;

namespace LinkedList
{
    public class Program
    {
//call method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateNodeAndList();

        }


        /// <summary>
        /// Creates a new Linked list and inserts new Nodes
        /// </summary>
        static void CreateNodeAndList()
        {
            Node node = new Node(10);
            Console.WriteLine(node.Value);
            LList list = new LList();
            list.Insert(3);
            list.Insert(10);
            list.Insert(15);

            list.Append(11);

            list.InsertBefore(10, 22);

            list.InsertAfter(3, 33);

            list.Print();
        }

    }
}

