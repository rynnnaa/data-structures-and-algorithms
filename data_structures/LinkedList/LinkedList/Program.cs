using System;
using LinkedList.Class;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

            LList list1 = new LList();
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                list1.Insert(arr[i]);

            }

            NodeList();

        }

        static void NodeList()
        {
            LList list = new LList();
            list.Insert(2);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);
            list.Insert(8);
            list.Insert(9);
            list.Insert(1);

            list.Append(15);
            list.Append(16);
            list.Append(17);

            list.InsertBefore(8, 7);

            list.InsertAfter(9, 10);

            list.Nodes();
            Console.ReadLine();
        }
    }
}

