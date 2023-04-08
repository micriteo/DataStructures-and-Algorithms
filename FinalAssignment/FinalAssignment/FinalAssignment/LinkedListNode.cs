namespace FinalAssignment;

public class LinkedListNode<T>:IComparable where T:IComparable
{
    public T Value { get; set; }

    public LinkedListNode<T> NextNode { get; set; }

    public LinkedListNode(T value)
    {
        this.Value = value;
        this.NextNode = null;
    }

    public int CompareTo(object? obj)
    {
        if (obj is LinkedListNode<T>)
        {
            return this.Value.CompareTo((obj as LinkedListNode<T>).Value);
        }

        if (obj is T)
        {
            return this.Value.CompareTo(obj);
        }

        return -1;
    }
}