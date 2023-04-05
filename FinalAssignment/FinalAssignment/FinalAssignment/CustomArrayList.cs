using System;

namespace FinalAssignment;

public class CustomArrayList<T> : ISortable<T>, ISearchable, ICustomCollection<T> where T : IComparable
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


    public T[] MergeSort()
    {
        T[] sortedArray = new T[this._count];
        Array.Copy(_array, sortedArray, _count);
        MergeSortHelper(sortedArray, 0, _count - 1);
        if (typeof(T) != typeof(string))
        {
            Array.Sort(sortedArray);
            return sortedArray;
        }
        else
        {
            Array.Reverse(sortedArray);
            return sortedArray;
        }
    }

    private void MergeSortHelper(T[] tempArray, int left, int right)
    {
        if (left >= right) return;
        {
            int middle = (left + right) / 2;

            MergeSortHelper(tempArray, left, middle);
            MergeSortHelper(tempArray, middle + 1, right);

            Merge(tempArray, left, middle, right);
        }
    }

    private void Merge(T[] tempArray, int left, int middle, int right)
    {
        // Create indices for the left and right subarrays
        int leftIndex = left;
        int rightIndex = middle + 1;

        // Create an index for the temporary array
        int tempIndex = 0;

        // Loop through the left and right subarrays, adding the smaller element to the temporary array
        while (leftIndex <= middle && rightIndex <= right)
        {
            if (_array[leftIndex].CompareTo(_array[rightIndex]) <= 0)
            {
                tempArray[tempIndex] = _array[leftIndex];
                leftIndex++;
            }
            else
            {
                tempArray[tempIndex] = _array[rightIndex];
                rightIndex++;
            }
            tempIndex++;
        }

        // Copy any remaining elements from the left subarray to the temporary array
        while (leftIndex <= middle)
        {
            tempArray[tempIndex] = _array[leftIndex];
            leftIndex++;
            tempIndex++;
        }

        // Copy any remaining elements from the right subarray to the temporary array
        while (rightIndex <= right)
        {
            tempArray[tempIndex] = _array[rightIndex];
            rightIndex++;
            tempIndex++;
        }

        // Copy the sorted elements from the temporary array back to the original array
        Array.Copy(tempArray, 0, _array, left, tempIndex);
    }


//    public InputType[] InsertSort()
//{
//    // Make a copy of the original array
//    T[] copy = new T[_count];
//    Array.Copy(_array, 0, copy, 0, _count);

//    // Sort the copy using InsertSort
//    for (int i = 1; i < _count; i++)
//    {
//        T temp = copy[i];
//        int j = i - 1;
//        while (j >= 0 && copy[j].CompareTo(temp) > 0)
//        {
//            copy[j + 1] = copy[j];
//            j--;
//        }
//        copy[j + 1] = temp;
//    }

//    // Convert the sorted array to an array of InputType and return it
//    InputType[] result = new InputType[_count];
//    for (int i = 0; i < _count; i++)
//    {
//        string valueString = copy[i].ToString();
//        result[i] = new InputType(valueString);
//    }
//    return result;
//}



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




    public T[] QuickSort()
    {
        T[] sortedArray = new T[this._count];
        Array.Copy(this._array, sortedArray, this._count);
        QuickSortHelper(sortedArray, 0, this._count - 1);
        Array.Reverse(sortedArray);
        return sortedArray;
    }

    private void QuickSortHelper(T[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSortHelper(arr, left, pivotIndex - 1);
            QuickSortHelper(arr, pivotIndex + 1, right);
        }
    }

    private int Partition(T[] arr, int left, int right)
    {
        T pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (Comparer<T>.Default.Compare(arr[j], pivot) <= 0)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, right);
        return i + 1;
    }

    private void Swap(T[] arr, int i, int j)
    {
        T temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    public void Clear()
    {
        // Set _count to 0 to empty the array
        _count = 0;

        // Create a new array with the original size and set it to _array
        _array = new T[_increment];
    }


}