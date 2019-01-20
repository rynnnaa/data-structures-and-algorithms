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
            LList list = new LList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);

            Console.WriteLine($"Does 2 exist: {list.Includes(3)}");
            Console.WriteLine($"Does 5 exist: {list.Includes(5)}");
            list.PrintNodes();
            Console.ReadLine();
        }

    }
}

