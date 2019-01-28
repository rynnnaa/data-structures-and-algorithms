using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public List<int> ArrList = new List<int>();

        public BinaryTree(Node node)
        {
            Root = node;
        }
    }
