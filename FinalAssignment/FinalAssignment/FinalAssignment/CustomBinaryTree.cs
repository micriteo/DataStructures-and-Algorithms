using System.Text;

namespace FinalAssignment;

public class CustomBinaryTree<T> : ICustomCollection<T> where T : IComparable
{
    public BinaryTreeNode<T>? Root { get; private set; }

    public void InorderTraversal(BinaryTreeNode<T>? node, ref StringBuilder values)
    {
        if (node is null) return;

        InorderTraversal(node.Left, ref values);
        values.Append(node.Value);
        values.Append(" ");
        InorderTraversal(node.Right, ref values);
    }

    public void PreorderTraversal(BinaryTreeNode<T>? node, ref StringBuilder values)
    {
        if (node is null) return;

        values.Append(node.Value);
        values.Append(" ");
        PreorderTraversal(node.Left, ref values);
        PreorderTraversal(node.Right, ref values);
    }

    public void PostorderTraversal(BinaryTreeNode<T>? node, ref StringBuilder values)
    {
        if (node is null) return;

        PostorderTraversal(node.Left, ref values);
        PostorderTraversal(node.Right, ref values);
        values.Append(node.Value);
        values.Append(" ");
    }

    public string GetCollectionValues()
    {
        StringBuilder values = new StringBuilder();

        InorderTraversal(Root, ref values);

        return values.ToString();
    }

    public void Add(T value)
    {
        if (Root is null)
        {
            Root = new BinaryTreeNode<T>(value);
        }
        else
        {
            AddRecursive(Root, value);
        }
    }

    private void AddRecursive(BinaryTreeNode<T> currentNode, T insertedValue)
    {
        if (currentNode.Value.CompareTo(insertedValue) <= -1)
        {
            if (currentNode.Left is null)
            {
                currentNode.Left = new BinaryTreeNode<T>(insertedValue);
            }
            else
            {
                AddRecursive(currentNode.Left, insertedValue);
            }
        }
        else if (currentNode.Value.CompareTo(insertedValue) >= 1)
        {
            if (currentNode.Right is null)
            {
                currentNode.Right = new BinaryTreeNode<T>(insertedValue);
            }
            else
            {
                AddRecursive(currentNode.Right, insertedValue);
            }
        }
    }

    public void Clear()
    {
        // The following does not work (most probably when the Root is set to null, the garbage collector removes every other associated node)
        // foreach (Node node in this.PostorderTraversal(this.Root))
        // {
        //     node = null;
        // }

        Root = null;
    }
}