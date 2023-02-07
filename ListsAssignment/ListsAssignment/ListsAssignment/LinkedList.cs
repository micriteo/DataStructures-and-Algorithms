using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAssignment
{
    internal class LinkedList
    {
        //Making a field for the head 
        public Node head { get; set; }
        public LinkedList()
        {

        }

        //Adding to the list

        public void Add(int value)
        {
            //If there is no head, set the Head to the new node
            if (head == null)
            {
                head = new Node(value);
                return;
            }

            Node current = head;

            //Loop the linked list to find the last node             
            while (current.Next != null)
            {
                
                current = current.Next;
            }

            //Add the new node to the end of the linked list
            current.Next = new Node(value);
        }


        //removing from list
        public void Remove(int value)
        {
            //stop the execution if there is no head 
            if (head == null)
            {
                return;
            }

            // If the head has the specified value, set the head to its next node
            if (head.NodeValue == value)
            {
                head = head.next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.NodeValue == value)
                {
                    current.Next = current.Next.Next;
                    return;
                }

                current = current.Next;
            }
        }




        //displaying the list
        public void PrintValues()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.NodeValue + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        //Reversing a linked list
        public void Reverse()
        {
            // If the list is empty or has only one node, there's nothing to reverse
            if (head == null || head.Next == null)
            {
                return;
            }

            // Initialize the current, previous and next nodes
            Node current = head; // Start from the head of the list
            Node previous = null; // The previous node is initially null
            Node next = null; // The next node is initially null

            // Traverse the list, reversing the links between nodes
            while (current != null)
            {
                next = current.Next; // Store the next node
                current.Next = previous; // Reverse the link to the previous node
                previous = current; // Move the previous node to the current node
                current = next; // Move the current node to the next node
            }

            // Update the head to the last node in the reversed list
            head = previous;
        }
    }
}
