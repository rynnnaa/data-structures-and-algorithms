using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ValueAtEnd(4);
        }

        public static int ValueAtEnd(int value)
        {
            int runner = 0;
            int coutner = 0;

            LList list = new LList();


            list.insert(2);
            list.insert(3);

            list.Current = list.Head;

            while (list.Current.Next != null)
            {
                counter++;
                if (counter >= value)
                {
                    runner++;
                }

                int counter2 = 0;

                list.Current = list.Head;

                while (list.Current.Next != null)
                {
                    counter2++;

                    if (runner == counter2)
                    {
                        Console.WriteLine(list.Current.Value);

                        return list.Current.Value;
                    }

                    list.Current = list.Current.Next;
                    {

                        return -1;
                    }


                }
            }
        }
    }
}
