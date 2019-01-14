using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Class
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        public int value { get; private set; }

        //public LList(NodeExample node)
        //{
        //    Head = node;
        //}
        public void Insert(int value) //Add to data structure {CREATE}
        {
            Node node = new Node(value); //creating node circle
            node.Next = Head; //drawing the arrows
            Head = node; //moving head to the new node
        }

        public bool Includes(int value) //does it exist, YES or NO (hence the return type, -> bool)
        {
            Current = Head;
            while (Current.Next != null) //not yet at the end of the linked list
            {
                if (Current.Value == value)
                {
                    return true;
                }
            }
            if (Current.Value == value)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            Current = Head;
            while(Current!= null)
            {
                Console.Write(Current.Value + "  ");
                Current = Current.Next;
            }
        }
        //output to the console the linked list
    }
}

