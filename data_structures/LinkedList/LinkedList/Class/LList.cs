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
        /// Searches Linked List to see if node exists
        /// </summary>
        /// <param name="value">Value Node</param>
        /// <returns>True if node exists and false if it does not</returns>
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
        public void PrintNodes()
        {
            Node Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
        }
    }
}

