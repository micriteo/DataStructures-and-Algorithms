using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinaryTree
    {
        private Node root;
        // pointer to the root node of the tree

        public BinaryTree()
        {
            root = null;
            // initialize the root node to null
        }

        //Insert new node into the binary tree
        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
                //if the tree is empty create a new root node
                return;
            }


            //if the root node is not null, we create a queue to hold the nodes that we will visit during the level order traversal.
            //we add the root node to the queue and then enter a loop that 

            Queue<Node> queue = new Queue<Node>();  // create a new queue to store nodes to be processed
            queue.Enqueue(root);  // enqueue the root node to start the level order traversal


            //during each iteration of the loop, we dequeue the next node from the front of the queue and check if its left child is null.
            //if it is, we create a new node with the given value and set it 


            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();  // dequeue the next node to be processed

                if (current.LeftNode == null)
                {   //if the left child is not null, we add it to the back of the queue to be visited later.
                    // if the current node does not have a left child, create a new node with the given value and make it the left child
                    current.LeftNode = new Node(value);
                    return;
                }
                else
                {
                    queue.Enqueue(current.LeftNode);  // if the current node has a left child, enqueue it to be processed in the next level of the tree
                }

                if (current.RightNode == null)
                {   //if the right child is not null, we add it to the back of the queue to be visited later.
                    // if the current node does not have a right child, create a new node with the given value and make it the right child
                    current.RightNode = new Node(value);
                    return;
                }
                else
                {
                    queue.Enqueue(current.RightNode);  // if the current node has a right child, enqueue it to be processed in the next level of the tree
                }
            }

        }
        // perform an inorder traversal of the binary tree
        // goes left to right to find the left leaf node then its parent then see if the right node has a left node
        // then recursivly go up the tree 
        // numbers in ascending order
        public void InOrderTraversal()
        {
            InOrderTraversal(root);
            Console.WriteLine();  // print a newline character to separate output from any subsequent text
        }

        // Helper function for performing an inorder traversal of the binary tree
        private void InOrderTraversal(Node current)
        {
            if (current != null)
            {
                InOrderTraversal(current.LeftNode);     // visit the left subtree
                Console.Write(current.Value + " ");  // print the current node's data
                InOrderTraversal(current.RightNode);    // visit the right subtree
            }
        }

    }
}
