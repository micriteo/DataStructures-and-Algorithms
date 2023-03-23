using System;

namespace FinalAssignment;

public class CustomArrayList<T> : ISortable, ISearchable, ICustomCollection<T> where T : IComparable
{
    private T[] _array;
    private int _count;
    private readonly int _increment = 5;

    public int Count
    {
        get
        {
            return this._count;
        }
    }

    public CustomArrayList()
    {
        this._array = new T[this._increment];
        this._count = 0;
    }


    public InputType[] QuickSort()
    {
        // Call the helper function to perform QuickSort on the entire array
        QuickSortHelper(0, _count - 1);

        // Convert the sorted array to an array of InputType and return it
        InputType[] result = new InputType[_count];
        for (int i = 0; i < _count; i++)
        {
            string valueString = _array[i].ToString();
            result[i] = new InputType(valueString);
        }
        return result;  
    }

    private void QuickSortHelper(int left, int right)
    {
        // Check the base case
        if (left >= right) return;

        // Choose the pivot as the last element of the current range
        T pivot = _array[right];

        // Partition the array and get the index of the pivot
        int pivotIndex = Partition(left, right, pivot);

        // Recursively sort the left and right subarrays
        QuickSortHelper(left, pivotIndex - 1);
        QuickSortHelper(pivotIndex + 1, right);
    }

    private int Partition(int left, int right, T pivot)
    {
        // Initialize the index of the smaller element
        int i = left - 1;

        // Loop through the range from left to right - 1
        for (int j = left; j <= right - 1; j++)
        {
            // If the current element is less than or equal to the pivot, swap it with the element at the current index
            if (_array[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(i, j);
            }
        }

        // Swap the pivot with the element at the next index
        Swap(i + 1, right);

        // Return the index of the pivot
        return i + 1;
    }

    private void Swap(int i, int j)
    {
        T temp = _array[i];
        _array[i] = _array[j];
        _array[j] = temp;
    }

    public InputType[] InsertSort()
    {
        throw new NotImplementedException();
    }

    public void Add(T item)
    {
        if (item == null) throw new ArgumentNullException();

        if(this._count == this._array.Length) 
        {
            T[] newArray = new T[this._array.Length * 2];
            Array.Copy(this._array, 0, newArray, 0, this._array.Length);
            _array = newArray;
        }
        // Find the index to insert the new element
        int insertIndex = 0;
        while (insertIndex < this._count && item.CompareTo(this._array[insertIndex]) > 0)
        {
            insertIndex++;
        }

        // Shift the existing elements to make space for the new element
        for (int i = this._count - 1; i >= insertIndex; i--)
        {
            this._array[i + 1] = this._array[i];
        }
        // Insert the new element
        this._array[insertIndex] = item;
        this._count++;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }
}