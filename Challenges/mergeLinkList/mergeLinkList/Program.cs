using LinkedList.Class;
using System;

namespace mergeLinkList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LList list = new LList();
            list.Insert(1);
            list.Insert(3);
            list.Insert(5);
            list.Insert(7);

            LList listTwo = new LList();
            list.Insert(2);
            list.Insert(4);
            list.Insert(6);
            list.Insert(8);

            mergeLinkList(list, listTwo);
        }

        /// <summary>
        /// Merging two linked list  in a zipper form
        /// </summary>
        /// <param name="list"></param>
        /// <param name="listTwo"></param>
        /// <returns>New LList listThree</returns>

        public static void LList MergeLinkedList(LList list, LList listTwo)
        {
            LList listThree = new LList();
        }
    }
}
