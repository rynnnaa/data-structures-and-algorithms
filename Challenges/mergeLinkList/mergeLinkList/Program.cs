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

            Merge(list, listTwo);
        }

        /// <summary>
        /// Merging two linked list  in a zipper form
        /// </summary>
        /// <param name="list"></param>
        /// <param name="listTwo"></param>
        /// <returns>New LList listThree</returns>

        public static LList Merge(LList list, LList listTwo)
        {
            LList listThree = new LList();
            list.Current = list.Head;
            listTwo.Current = listTwo.Head;

            while (list.Current != null || listTwo.Current != null)
            {
                listThree.Insert(listTwo.Current.Value);
                listThree.Insert(listTwo.Current.Value);

                list.Current = list.Current.Next;
                listTwo.Current = listTwo.Current.Next;
            }
            listThree.Print();
            return listThree;
        }
        
    }
}
