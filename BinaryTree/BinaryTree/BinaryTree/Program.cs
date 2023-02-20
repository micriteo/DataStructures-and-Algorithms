namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(5);    // insert some nodes into the binary tree
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(8);

            Console.WriteLine("Inorder traversal of binary tree is: ");
            tree.InOrderTraversal();   // perform an inorder traversal of the binary tree and print the results

            Console.ReadLine();   // wait for user input before exiting
        }
    }
}