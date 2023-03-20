namespace FinalAssignment;

public class LinkedListNode<T> where T:IComparable
{
    public T Value { get; }

    public LinkedListNode<T> NextNode { get; set; }

    public LinkedListNode(T value)
    {
        this.Value = value;
        this.NextNode = null;
    }
}