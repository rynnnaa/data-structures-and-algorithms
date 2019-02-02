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
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);

            list.Append(7);
            list.Append(30);
            list.InsertBefore(4, 23);

            list.InsertAfter(5, 14);

            list.Print();
            Console.ReadLine();
        }
    }
}
