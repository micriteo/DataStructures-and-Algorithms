using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAssignment
{
    internal class Node
    {
        public int nodeValue;
        public Node next;
        public Node previous;

        //Constructor
        public Node(int nodeValue)
        {
            this.NodeValue = nodeValue;
            this.Next = next;
            this.Previous = previous;
        }
        
        public int NodeValue
        {
            get
            {
                return this.nodeValue;
            }
            set
            { 
                nodeValue = value; 
            }
        }

        public Node Next
        {
            get
            {
                return this.next;
            }
            set
            {
                next = value;
            }
        }

        public Node Previous
        {
            get
            {
                return this.previous;
            }
            set
            {
                previous = value;
            }
        }
    }
}
