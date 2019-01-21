using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Class
{
    public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Search Linked List to see if node exists
        /// </summary>
        /// <param name="value">Value Node</param>
        /// <returns>True if node exists, false if it does not</returns>
        /// 


        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }

                Current = Current.Next;
            }

            if (Current.Value == value)
            {
                return true;
            }

            return false;
        }



        /// <summary>
        /// Prints all existing Nodes to the Console
        /// </summary>
        public void Print()
        {
            Current = Head;
            Console.Write("Values of linked list: ");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value}, ");
                Current = Current.Next;
            }
            Console.WriteLine($"{Current.Value}");
        }

        public void Append(int value)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Node node = new Node(value);

            Current.Next = node;

        }

        public void Nodes()
        {
            Node Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
        }

        public void Appened(int value)
        {
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Node node = new Node(value);
            Current.Next = node;
        }

        public void InsertBefore(int value, int newValue)
        {
            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
        }

            public void InsertAfter(int value, int newValue)
            {
                Current = Head;

                while (Current.Next != null)
                {

                    if (Current.Value == value)
                    {

                        Node node = new Node(newValue);
                        node.Next = Current.Next;
                        Current.Next = node;
                        return;
                    }

                    Current = Current.Next;
                }
            }

    }
}

