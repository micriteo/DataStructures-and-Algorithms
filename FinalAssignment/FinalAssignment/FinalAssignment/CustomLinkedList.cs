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
        CheckIndex(index);

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
        CheckIndex(index);

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
        
        yield return currentNode.Value;

        while (currentNode.NextNode is not null)
        {
            currentNode = currentNode.NextNode;
            yield return currentNode.Value;
        }
    }

    private void CheckIndex(int index)
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
        CustomLinkedList<T> copy = this.GetCopy();

        QuickSort(copy, 0, this.Count - 1);

        return copy.ToArray();
    }

    private void QuickSort(CustomLinkedList<T> linkedList, int left, int right)
    {
        if (left < right)
        {
            // pi is partitioning index, linkedList[p]
            // is now at right place
            int pivotIndex = Partition(linkedList, left, right);
    
            // Separately sort elements before
            // partition and after partition
            QuickSort(linkedList, left, pivotIndex - 1);
            QuickSort(linkedList, pivotIndex + 1, right);
        }
    }
    
    private int Partition(CustomLinkedList<T> linkedList, int left, int right)
    {
        // pivot
        LinkedListNode<T> pivot = linkedList.Get(right);
    
        // Index of smaller element and indicates the right position of pivot found so far
        int pivotCorrectIndex = (left - 1);
    
        for (int j = left; j <= right - 1; j++)
        {
            // If current element is smaller than the pivot
            if (linkedList.Get(j).CompareTo(pivot) > 0)
            {
                // Increment index of smaller element
                pivotCorrectIndex++;
                Swap(linkedList, pivotCorrectIndex, j);
            }
        }
    
        Swap(linkedList, pivotCorrectIndex + 1, right);
        return (pivotCorrectIndex + 1);
    }
    
    private void Swap(CustomLinkedList<T> linkedList, int left, int right)
    {
        if (left == right)
        {
            return;
        }
        // Imagine not spending two days on this function, just to make it one line the end (from more than 20)...
        (linkedList.Get(left).Value, linkedList.Get(right).Value) = (linkedList.Get(right).Value, linkedList.Get(left).Value);
    }
    // Quick Sort above ========================================================

    // Merge Sort below ========================================================
    public T[] MergeSort()
    {
        CustomLinkedList<T> copy = this.GetCopy();

        MergeSort(copy);

        return copy.ToArray();
    }

    private void MergeSort(CustomLinkedList<T> linkedList)
    {
        if (linkedList.Count <= 1) // Base case: array of length 1 is already sorted
        {
            return;
        }

        int mid = linkedList.Count / 2; // Find the middle index

        // Divide the array into left and right halves
        CustomLinkedList<T> left = new();
        CustomLinkedList<T> right = new();

        int index = 0;
        foreach (T value in linkedList.GetEnumerable())
        {
            if (index < mid)
            {
                // Copy first half of array to left array
                left.Add(value);
            }
            else
            {
                // Copy second half of array to right array
                right.Add(value);
            }

            index++;
        }

        // Recursively sort the left and right halves
        MergeSort(left);
        MergeSort(right);

        // Merge the sorted halves
        int i = 0, j = 0, k = 0;
        while (i < left.Count && j < right.Count)
        {
            if (left.Get(i).CompareTo(right.Get(j)) > 0)
            {
                linkedList.Get(k++).Value = left.Get(i++).Value; 
            }
            else
            {
                linkedList.Get(k++).Value = right.Get(j++).Value;
            }
        }

        // Add remaining elements from left array
        while (i < left.Count) 
        {
            linkedList.Get(k++).Value = left.Get(i++).Value;
        }

        // Add remaining elements from right array
        while (j < right.Count)
        {
            linkedList.Get(k++).Value = right.Get(j++).Value;
        }
    }
    // Merge Sort above ========================================================

    // Jump Search below =======================================================
    public int JumpSearch(InputType target)
    {
        CustomLinkedList<T> copyLinkedList = this.GetCopy();
        // The array must be sorted (merge sort proved to be the fastest)
        MergeSort(copyLinkedList);

        // Math floor to get the integer part of the square root (so both 2.2 or 2.7 will return 2)
        int step = (int)Math.Floor(Math.Sqrt(copyLinkedList.Count));

        int left = 0;
        int right = step; 
        while (right < copyLinkedList.Count)
        {
            if (copyLinkedList.Get(right).CompareTo(target) < 0)
            {
                break;
            }
            left = right;
            right += step;
        }

        // If right is out of bounds, set it to the last index
        right = Math.Min(right, copyLinkedList.Count - 1);

        // Perform a linear search
        for (int i = left; i <= right; i++)
        {
            if (copyLinkedList.Get(i).CompareTo(target) == 0)
            {
                // Value found at index i
                return i;
            }
        }

        // Value was not found
        return -1;
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

    private CustomLinkedList<T> GetCopy()
    {
        CustomLinkedList<T> copy = new CustomLinkedList<T>();
        foreach (T value in GetEnumerable())
        {
            copy.Add(value);
        }

        return copy;
    }
}