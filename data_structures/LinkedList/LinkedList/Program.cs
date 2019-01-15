using System;
using LinkedList.Class;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            LList list1 = new LList();
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                list1.Insert(arr[i]);

            }

            NodeList();

        }


    }
}

