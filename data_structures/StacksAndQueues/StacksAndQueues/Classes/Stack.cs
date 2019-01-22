using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        public Stack()
        {

        }

        public void Push(int value)
        {
            Node node = new Node(value);
        }
    }
}
