namespace DataStructures_LinkedList
{
    public class LinkedListNode <T>
    {
        public LinkedListNode(T value)
        {
            this.Value = value;
            this.NextNode = null;
        }

        public T Value { get; }

        public LinkedListNode<T> NextNode { get; set; }
    }
}