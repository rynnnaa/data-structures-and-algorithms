using LinkedList.Class;
using System;

namespace mergeLinkList
{
    public class Program
    {
        /// <summary>
        /// creates two lists and call method to merge
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            LList list1 = new LList();
            list1.Insert(1);
            list1.Insert(3);
            list1.Insert(5);
            list1.Insert(7);
            list1.Insert(9);

            LList list2 = new LList();
            list2.Insert(2);
            list2.Insert(4);
            list2.Insert(6);
            list2.Insert(8);
            list2.Insert(10);

            Merge(list1, list2);

        }

        /// <summary>
        /// Merge two link lists in zipper formation
        /// </summary>
        /// <param name="list"></param>
        /// <param name="list2"></param>
        /// <returns>New LList</returns>
        public static LList Merge(LList list, LList list2)
        {
            LList list3 = new LList();
            list.Current = list.Head;
            list2.Current = list2.Head;

            while (list.Current != null || list2.Current != null)
            {
                list3.Insert(list2.Current.Value);
                list3.Insert(list.Current.Value);


                list.Current = list.Current.Next;
                list2.Current = list2.Current.Next;
            }

            list3.Print();
            return list3;
        }


    }
}