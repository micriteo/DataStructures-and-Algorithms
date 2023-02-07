using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAssignment
{
    internal class DoubleLinkedList
    {
        // Head of the linked list
        public Node head { get; set; }
        
        // Tail of the linked list
        public Node tail { get; set; }

        // Method to add a node to the linked list
        public void Add(int value)
        {
            // If the linked list is empty, add the node as the head and tail
            if (head == null)
            {
                head = new Node(value);
                tail = head;
                return;
            }
            
            // Create a new node with the specified value
            Node newNode = new Node(value);
            
            // Set the next node for the current tail to be the new node
            tail.Next = newNode;

            // Set the previous node for the new node to be the current tail
            newNode.Previous = tail;

            // Update the tail of the linked list to be the new node
            tail = newNode;
        }


        // Method to remove a node with the specified value from the linked list
        public void Remove(int value)
        {

            // If the linked list is empty, return
            if (head == null) return;

            if (head.NodeValue == value)
            {
                head = head.Next;
                head.Previous = null;
                return;
            }

            // Traverse the linked list to find the node with the specified value
            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.NodeValue == value)
                {
                    // Remove the node by skipping over it
                    current.Next = current.Next.Next;

                    // If there's still a node after the removed node, update its previous node to be the current node
                    if (current.Next != null)
                    {
                        current.Next.Previous = current;
                    }
                    // If there's no node after the removed node, update the tail of the linked list to be the current node
                    else
                    {
                        tail = current;
                    }
                    return;
                }
            }
        }
    }
}
