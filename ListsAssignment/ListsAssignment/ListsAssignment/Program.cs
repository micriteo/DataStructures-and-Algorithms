using System;

namespace ListsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new linked list
            LinkedList list = new LinkedList();

            // Add some values to the linked list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            // Print the values in the linked list
            list.PrintValues();
            //Output 1 2 3 
            //Remove the node with the specified values
            list.Remove(2);
            //Print the new values from the list
            list.PrintValues();
            //Output 1 2 


            //Double Linked List

            // Add some values to the linked list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            // Print the values in the linked list
            list.PrintValues();
            // Output: 1 2 3 4 

            // Remove a value from the linked list
            list.Remove(2);

            // Print the values in the linked list again
            list.PrintValues();
            // Output: 1 3 4 


            Console.WriteLine("Original list: ");
            //Output: 1 2 3 4
            list.PrintValues();

            //Reverse the list 
            list.Reverse();


            //Print the reversed list
            Console.WriteLine("Reversed list: ");
            list.PrintValues();

            Console.ReadKey();
        }
    }
}  