using System;

namespace FinalAssignment;

public class CustomArrayList<T> : ISortable, ISearchable, IInsertable<T> where T : IComparable
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

        // Choose a random pivot element
        int pivotIndex = (left + right) / 2;
        T pivot = _array[pivotIndex];

        // Swap the pivot element with the last element in the current range
        Swap(pivotIndex, right);

        // Partition the array and get the index of the pivot
        pivotIndex = Partition(left, right, pivot);

        // Recursively sort the left and right subarrays
        QuickSortHelper(left, pivotIndex - 1);
        QuickSortHelper(pivotIndex + 1, right);
    }

    private int Partition(int left, int right, T pivot)
    {
        // Initialize the index of the smaller element
        int i = left - 1;

        // Loop through the range from left to right - 1
        for (int j = left; j <= right; j++)
        {
            // If the current element is less than or equal to the pivot, swap it with the element at the current index
            if (_array[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(i, j);
            }
        }
        // Swap the pivot element with the element at the final index of the left subarray
        Swap(i + 1, right);

        // Return the index of the pivot
        return i + 1;
    }

    private void Swap(int i, int j)
    {
        if (i == j) return; // No need to swap if the indices are the same

        T temp = _array[i];
        _array[i] = _array[j];
        _array[j] = temp;
    }

 public InputType[] InsertSort()
{
    // Make a copy of the original array
    T[] copy = new T[_count];
    Array.Copy(_array, 0, copy, 0, _count);

    // Sort the copy using InsertSort
    for (int i = 1; i < _count; i++)
    {
        T temp = copy[i];
        int j = i - 1;
        while (j >= 0 && copy[j].CompareTo(temp) > 0)
        {
            copy[j + 1] = copy[j];
            j--;
        }
        copy[j + 1] = temp;
    }

    // Convert the sorted array to an array of InputType and return it
    InputType[] result = new InputType[_count];
    for (int i = 0; i < _count; i++)
    {
        string valueString = copy[i].ToString();
        result[i] = new InputType(valueString);
    }
    return result;
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
        while (insertIndex < this._count && item.CompareTo(this._array[insertIndex]) >= 0)
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
}