using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Custom linked list example
            Console.WriteLine("Linked List example");
            LinkedList<int> linkedList = new();

            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            Console.WriteLine("List after adding elements:");
            PrintList(linkedList);

            linkedList.Remove(0);
            Console.WriteLine("List after removing an element:");
            PrintList(linkedList);

            Console.WriteLine("Elements count in the list:");
            Console.WriteLine(linkedList.Count);

            Console.WriteLine("Element at index 1:");
            Console.WriteLine(linkedList.Get(1));

            // Custom double linked list example
            Console.WriteLine("\n\nDouble Linked List example");
            DoubleLinkedList<int> doubleLinkedList = new();

            doubleLinkedList.Add(1);
            doubleLinkedList.Add(2);
            doubleLinkedList.Add(3);

            Console.WriteLine("List after adding elements:");
            PrintList(doubleLinkedList);

            doubleLinkedList.Remove(2);
            Console.WriteLine("List after removing an element:");
            PrintList(doubleLinkedList);

            Console.WriteLine("Elements count in the list:");
            Console.WriteLine(doubleLinkedList.Count);

            Console.WriteLine("Element at index 1:");
            Console.WriteLine(doubleLinkedList.Get(1));
        }

        private static void PrintList(IPrintable list)
        {
            Console.WriteLine("Printing the list:");
            foreach (var obj in list.GetEnumerable())
            {
                Console.WriteLine(obj);
            }
        }
    }
}
