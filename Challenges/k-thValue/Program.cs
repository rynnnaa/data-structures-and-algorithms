using System;
using LinkedList.Class;

namespace k_thValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            ValueByEnd(4);
        }

        public static int ValueByEnd(int value)
        {
            int runner = 0;
            int counter = 0;
            LList list = new LList();


            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
            list.Insert(6);

            list.Current = list.Head;

            while (list.Current.Next != null)
            {
                counter++;

                if (counter >= value)
                {
                    runner++;
                }

                list.Current = list.Current.Next;
            }

            if (value > counter)
            {
                Console.WriteLine("That node does not exist");
            }

            int counter2 = 0;

            list.Current = list.Head;
            //gets and returns the vlaue of the node
            while (list.Current.Next != null)
            {
                counter2++;

                if (runner == counter2)
                {
                    Console.WriteLine(list.Current.Value);

                    return list.Current.Value;

                }
                list.Current = list.Current.Next;
            }

            return -1;



        }
    }
}