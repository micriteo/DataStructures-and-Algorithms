namespace DataStructures_LinkedList
{
    public class DoubleLinkedListNode <T>
    {

        public DoubleLinkedListNode(T value)
        {
            this.Value = value;
            this.PreviousNode = null;
            this.NextNode = null;
        }

        public T Value { get;  }

        public DoubleLinkedListNode<T> NextNode { get; set; }

        public DoubleLinkedListNode<T> PreviousNode { get; set; }
    }
}