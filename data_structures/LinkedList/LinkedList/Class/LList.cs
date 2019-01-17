using System;

namespace LinkedList.Class
{
    public class LList
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
            while (Current != null)
            {
                Console.Write(Current.Value + "  ");
                Current = Current.Next;
            }
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

