using Microsoft.VisualBasic.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FinalAssignment;

public class CustomLinkedList<T> : ICustomCollection<T>, ISortable<T> where T:IComparable
{
    private LinkedListNode<T> _root;
    private int _count;

    public int Count => this._count;

    // OLD IMPLEMENTATION
    // public int Count
    // {
    //     get
    //     {
    //         int count = 0;
    //         LinkedListNode<T> currentNode = this._root;
    //
    //         if (currentNode is null)
    //         {
    //             return count;
    //         }
    //
    //         // The list has one element
    //         count++;
    //         while (currentNode.NextNode is not null)
    //         {
    //             count++;
    //             currentNode = currentNode.NextNode;
    //         }
    //
    //         return count;
    //     }
    // }

    public CustomLinkedList()
    {
        this._root = null;
        this._count = 0;
    }

    public void Add(T data)
    {
        if (this._root is null)
        {
            this._root = new LinkedListNode<T>(data);
        }
        else
        {
            LinkedListNode<T> currentNode = this._root;

            while (currentNode.NextNode is not null)
            {
                currentNode = currentNode.NextNode;
            }

            currentNode.NextNode = new LinkedListNode<T>(data);
        }
        
        this._count++;
    }

    public void Remove(int index)
    {
        checkIndex(index);

        LinkedListNode<T> previousNode = this._root;
        LinkedListNode<T> currentNode = this._root.NextNode;

        // If the head node is the one to be removed
        if (index == 0)
        {
            this._root = currentNode;
            this._count--;
            return;
        }

        int currentIndex = 1;
        while (previousNode.NextNode is not null)
        {
            if (currentIndex == index)
            {
                previousNode.NextNode = currentNode.NextNode;
                currentNode = null;
                this._count--;
                break;
            }

            previousNode = currentNode;
            currentNode = currentNode.NextNode;
            currentIndex++;
        }
    }

    public LinkedListNode<T> Get(int index)
    {
        checkIndex(index);

        LinkedListNode<T> currentNode = this._root;

        // If the element to be returned is the head node
        if (index == 0)
        {
            return currentNode;
        }

        int currentIndex = 1;
        while (currentNode.NextNode is not null)
        {
            if (currentIndex == index)
            {
                return currentNode.NextNode;
            }

            currentNode = currentNode.NextNode;
            currentIndex++;
        }

        // return currentNode.Value;
        throw new EntryPointNotFoundException("No found node in the linked list!");
    }

    public IEnumerable GetEnumerable()
    {
        LinkedListNode<T> currentNode = this._root;

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
        if (index >= this.Count || index < 0)
        {
            throw new IndexOutOfRangeException();
        }
    }

    public void Clear()
    {
        // Teacher not like this (although C# smart as it has garbage collector)
        // this._root = null;

        // So we smarter then
        for(int i = this.Count - 1; i >= 0; i--)
        {
            this.Remove(i);
        }
    }

    // Quick Sort below ========================================================
    public T[] QuickSort()
    {
        // Make a copy of this collection
        CustomLinkedList<T> copy = new CustomLinkedList<T>();
        foreach (T value in GetEnumerable())
        {
            copy.Add(value);
        }

        QuickSort(copy, 0, this.Count - 1);

        return copy.ToArray();
    }

    private void QuickSort(CustomLinkedList<T> arr, int left, int right)
    {
        if (left < right)
        {
            // pi is partitioning index, arr[p]
            // is now at right place
            int pi = Partition(arr, left, right);
    
            // Separately sort elements before
            // partition and after partition
            QuickSort(arr, left, pi - 1);
            QuickSort(arr, pi + 1, right);
        }
    }
    
    private int Partition(CustomLinkedList<T> arr, int left, int right)
    {
        // pivot
        T pivot = arr.Get(right).Value;
    
        // Index of smaller element and
        // indicates the right position
        // of pivot found so far
        int i = (left - 1);
    
        for (int j = left; j <= right - 1; j++)
        {
            // If current element is smaller
            // than the pivot
            if (arr.Get(j).Value.CompareTo(pivot) < 0)
            {
                // Increment index of
                // smaller element
                i++;
                Swap(arr, i, j);
            }
        }
    
        Swap(arr, i + 1, right);
        return (i + 1);
    }
    
    private void Swap(CustomLinkedList<T> arr, int left, int right)
    {
        if (left == right)
        {
            return;
        }

        LinkedListNode<T> leftNode = arr.Get(left);
        LinkedListNode<T> rightNode = arr.Get(right);

        (leftNode, rightNode) = (rightNode, leftNode);
        // var a = arr;
        (leftNode.NextNode, rightNode.NextNode) = (rightNode.NextNode, leftNode.NextNode);
    }
    // Quick Sort above ========================================================

    // Merge Sort below ========================================================
    public T[] MergeSort()
    {
        throw new NotImplementedException();
    }
    // Merge Sort above ========================================================

    // Jump Search below =======================================================
    public int JumpSearch(InputType target)
    {
        throw new NotImplementedException();
    }
    // Jump Search above =======================================================

    public string GetCollectionValues()
    {
        StringBuilder values = new StringBuilder();

        foreach (T value in GetEnumerable())
        {
            values.Append(value);
            values.Append(" ");
        }

        return values.ToString();
    }

    public T[] ToArray()
    {
        T[] array = new T[this.Count];

        int index = 0;
        foreach (T value in GetEnumerable())
        {
            // First the index will be passed, then incremented
            array[index++] = value;
        }

        return array;
    }
}