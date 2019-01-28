using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            if (Root == null)
            {
                Root = node;
            }

            else
            {
                Add(Root, node.Value);
            }
        }
    }
}
