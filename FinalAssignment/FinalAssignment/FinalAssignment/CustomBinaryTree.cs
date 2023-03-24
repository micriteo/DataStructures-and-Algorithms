using System.Text;

namespace FinalAssignment;

public class CustomBinaryTree<T>:ICustomCollection<T> where T:IComparable
{
    private BinaryTreeNode<T> _root;
    public BinaryTreeNode<T> Root => this._root;

    public void InorderTraversal(BinaryTreeNode<T> node, ref StringBuilder values)
    {
        if (node is null)
        {
            return;
        }

        InorderTraversal(node.Left, ref values);
        values.Append(node.Value);
        values.Append(" ");
        InorderTraversal(node.Right, ref values);
    }

    public void PreorderTraversal(BinaryTreeNode<T> node, ref StringBuilder values)
    {
        if (node is null)
        {
            return;    
        }

        values.Append(node.Value);
        values.Append(" ");
        PreorderTraversal(node.Left, ref values);
        PreorderTraversal(node.Right, ref values);
    }

    public void PostorderTraversal(BinaryTreeNode<T> node, ref StringBuilder values)
    {
        if (node is null)
        {
            return;
        }

        PostorderTraversal(node.Left, ref values);
        PostorderTraversal(node.Right, ref values);
        values.Append(node.Value);
        values.Append(" ");
    }

    public void Add(T insertedValue)
    {
        if (this.Root is null)
        {
            this._root = new(insertedValue);
        }
        else
        {
            this.AddRecursive(this.Root, insertedValue);
        }
    }

    private void AddRecursive(BinaryTreeNode<T> currentNode, T insertedValue)
    {
        if (currentNode.Value.CompareTo(insertedValue) <= -1)
        {
            if (currentNode.Left is null)
            {
                currentNode.Left = new(insertedValue);
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
                currentNode.Right = new(insertedValue);
            }
            else
            {
                AddRecursive(currentNode.Right, insertedValue);
            }
        }
    }

    public void Clear()
    {
        // foreach (Node node in this.PostorderTraversal(this.Root))
        // {
        //     node = null;
        // }

        this._root = null;
    }
}