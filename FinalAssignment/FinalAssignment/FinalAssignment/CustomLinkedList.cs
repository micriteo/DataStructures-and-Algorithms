using System.Collections;

namespace FinalAssignment;

public class CustomLinkedList<T> where T:IComparable
{
    private LinkedListNode<T> _headNode;

    public CustomLinkedList()
    {
        this._headNode = null;
    }

    public void Add(T data)
    {
        if (this._headNode is null)
        {
            this._headNode = new LinkedListNode<T>(data);
        }
        else
        {
            LinkedListNode<T> currentNode = this._headNode;

            while (currentNode.NextNode is not null)
            {
                currentNode = currentNode.NextNode;
            }

            currentNode.NextNode = new LinkedListNode<T>(data);
        }
    }

    public void Remove(int index)
    {
        checkIndex(index);

        LinkedListNode<T> previousNode = this._headNode;
        LinkedListNode<T> currentNode = this._headNode.NextNode;

        // If the head node is the one to be removed
        if (index == 0)
        {
            this._headNode = currentNode;
            return;
        }

        int currentIndex = 1;
        while (previousNode.NextNode is not null)
        {
            if (currentIndex == index)
            {
                previousNode.NextNode = currentNode.NextNode;
                currentNode = null;
                break;
            }

            previousNode = currentNode;
            currentNode = currentNode.NextNode;
            currentIndex++;
        }
    }

    public T Get(int index)
    {
        checkIndex(index);

        LinkedListNode<T> currentNode = this._headNode;

        // If the element to be returned is the head node
        if (index == 0)
        {
            return currentNode.Value;
        }

        int currentIndex = 1;
        while (currentNode.NextNode is not null)
        {
            if (currentIndex == index)
            {
                return currentNode.NextNode.Value;
            }

            currentNode = currentNode.NextNode;
        }

        // return currentNode.Value;
        throw new EntryPointNotFoundException();
    }

    public int Count
    {
        get
        {
            int count = 0;
            LinkedListNode<T> currentNode = this._headNode;

            if (currentNode is null)
            {
                return count;
            }

            // The list has one element
            count++;
            while (currentNode.NextNode is not null)
            {
                count++;
                currentNode = currentNode.NextNode;
            }

            return count;
        }
    }

    public IEnumerable GetEnumerable()
    {
        LinkedListNode<T> currentNode = this._headNode;

        if (currentNode is null)
        {
            yield break;
        }
        else
        {
            yield return currentNode.Value;
        }

        while (currentNode.NextNode is not null)
        {
            currentNode = currentNode.NextNode;
            yield return currentNode.Value;
        }
    }

    private void checkIndex(int index)
    {
        if (index >= Count)
        {
            throw new IndexOutOfRangeException();
        }
    }
}