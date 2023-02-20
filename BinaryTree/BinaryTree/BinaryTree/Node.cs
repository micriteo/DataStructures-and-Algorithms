using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Node
    {
        private int value;
        public int Value
        {
            get { return value; }
        }
        private Node leftNode;
        public Node LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }
        
        private Node rightNode;
        public Node RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }



        public Node(int value)
        {
            this.value = value;
            this.leftNode = null;
            this.rightNode = null;
        }
    }
}
