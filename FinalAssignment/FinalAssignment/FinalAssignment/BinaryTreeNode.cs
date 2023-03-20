namespace FinalAssignment;

public class BinaryTreeNode<T> where T:IComparable
{
    public T Value { get; }
    public BinaryTreeNode<T> Left { get; set; }
    public BinaryTreeNode<T> Right { get; set; }

    public BinaryTreeNode(T value)
    {
        this.Value = value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}
