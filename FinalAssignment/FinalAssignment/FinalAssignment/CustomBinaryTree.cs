using System.Text;
using System.Xml.Linq;

namespace FinalAssignment;

public class CustomBinaryTree<T>:IInsertable<T> where T:IComparable
{
    private BinaryTreeNode<T> _root;
    public BinaryTreeNode<T> Root => this._root;

    public void InorderTraversal(BinaryTreeNode<T> node, ref StringBuilder values)
    {
        if (node is not null)
        {
            InorderTraversal(node.Left, ref values);
            values.Append(node.Value);
            values.Append(" ");
            InorderTraversal(node.Right, ref values);
        }
    }

    public void PreorderTraversal(BinaryTreeNode<T> node, ref StringBuilder values)
    {
        if (node is not null)
        {
            values.Append(node.Value);
            values.Append(" ");
            PreorderTraversal(node.Left, ref values);
            PreorderTraversal(node.Right, ref values);
        }
    }

    public void PostorderTraversal(BinaryTreeNode<T> node, ref StringBuilder values)
    {
        if (node is not null)
        {
            PostorderTraversal(node.Left, ref values);
            PostorderTraversal(node.Right, ref values);
            values.Append(node.Value);
            values.Append(" ");
        }
    }

    public void Add(T insertedValue)
    {
        BinaryTreeNode<T> node = new(insertedValue);

        if (this.Root is not null)
        {
            BinaryTreeNode<T> currentNode = this.Root;

            while (true)
            {
                if (currentNode.Value.CompareTo(insertedValue) >= 1)
                {
                    if (currentNode.Left is null)
                    {
                        currentNode.Left = node;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.Left;
                    }
                }
                else
                {
                    if (currentNode.Right is null)
                    {
                        currentNode.Right = node;
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                    }
                }
            }
        }
        else
        {
            this._root = node;
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