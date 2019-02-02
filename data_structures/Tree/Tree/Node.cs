using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Node
    {
        private object value;

        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
        }

        public Node(object value)
        {
            this.value = value;
        }
    }
}
