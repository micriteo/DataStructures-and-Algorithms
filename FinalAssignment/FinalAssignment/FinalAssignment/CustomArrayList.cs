using System;
using System.Text;

namespace FinalAssignment;

public class CustomArrayList<T> : ICustomCollection<T>, ISortable<T> where T : IComparable
{
    private T[] _array;
    private int _count;
    private readonly int Increment = 5;

    public int Count => this._count;

    public CustomArrayList()
    {
        this._array = new T[this.Increment];
        this._count = 0;
    }

    public void Add(T? item)
    {
        if (item is null) throw new ArgumentNullException();

        // Increasing array's size if it reached its limit
        if (this.Count == this._array.Length)
        {
            T[] newArray = new T[this._array.Length + this.Increment];
            Array.Copy(this._array, 0, newArray, 0, this._array.Length);
            this._array = newArray;
        }

        for (int i = 0; i < this._array.Length; i++)
        {
            if (this._array[i] is null)
            {
                this._array[i] = item;
                this._count++;
                return;
            }
        }

        // Should never reach here!
        throw new EndOfStreamException("The array was full with non-null items!");
    }

    public T[] MergeSort()
    {
        // Create a new array to hold the sorted elements and copy the original array to it
        T[] sortedArray = new T[this._count];
        Array.Copy(this._array, sortedArray, _count);

        // Call the recursive helper function to perform the sort
        MergeSortHelper(sortedArray, 0, this.Count - 1);


        // If the element type is InputType, check if it is a string and sort or reverse the array accordingly
        if (typeof(T) == typeof(InputType))
        {
            if (typeof(InputType).IsAssignableFrom(typeof(T)))
            {
                if (sortedArray.All(x => ((InputType)(object)x).IsString()))
                {
                    Array.Sort(sortedArray);
                }
                else
                {
                    Array.Reverse(sortedArray);
                }
            }
        }
        // If the element type is int, reverse the array
        else if (typeof(T) == typeof(int))
        {
            Array.Reverse(sortedArray);
        }

        // Return the sorted array
        return sortedArray;
    }

    private void MergeSortHelper(T[] tempArray, int left, int right)
    {
        // If the left and right indices are the same or crossed, the array is sorted
        if (left >= right) return;
        {
            // Find the middle index and recursively sort the left and right halves
            int middle = (left + right) / 2;

            MergeSortHelper(tempArray, left, middle);
            MergeSortHelper(tempArray, middle + 1, right);

            // Merge the sorted halves
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

    public T[] QuickSort()
    {
        T[] sortedArray = new T[this._count];
        Array.Copy(this._array, sortedArray, this._count);
        
        QuickSortHelper(sortedArray, 0, this._count - 1);
        // If the element type is InputType, check if it is a string and sort or reverse the array accordingly
        if (typeof(T) == typeof(InputType))
        {
            if (typeof(InputType).IsAssignableFrom(typeof(T)))
            {
                if (sortedArray.All(x => ((InputType)(object)x).IsString()))
                {
                    Array.Sort(sortedArray);
                }
                else
                {
                    Array.Reverse(sortedArray);
                }
            }
        }
        // If the element type is int, reverse the array
        else if (typeof(T) == typeof(int))
        {
            Array.Reverse(sortedArray);
        }

        // Return the sorted array
        return sortedArray;
    }
    

    private void QuickSortHelper(T[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSortHelper(arr, left, pivotIndex - 1);
            //Left Partition
            QuickSortHelper(arr, pivotIndex + 1, right);
            //Right Partition
        }
    }

    private int Partition(T[] arr, int left, int right)
        //Location of our pivot
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
        // Magic... (also called "swap using deconstruction")
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }

    public void Clear()
    {
        // Set _count to 0 to empty the array
        this._count = 0;

        // Create a new array with the original size and set it to _array
        this._array = new T[Increment];
    }

    public int JumpSearch(InputType target)
    {
        // Check if the array is empty
        if (this._count == 0)
        {
            return -1;
        }

        // Check if the array is sorted in ascending order
        bool isSorted = true;
        for (int i = 1; i < this._count; i++)
        {
            if (this._array[i].CompareTo(this._array[i - 1]) < 0)
            {
                isSorted = false;
                break;
            }
        }

        if (!isSorted)
        {
            throw new InvalidOperationException("JumpSearch can only be performed on a sorted array.");
        }

        // Set the jump size to the square root of the array length
        int jumpSize = (int)Math.Floor(Math.Sqrt(this._count));

        // Loop through the array using the jump size as the step
        for (int i = 0; i < this._count; i += jumpSize)
        {
            // Check if the current element is greater than the target
            if (this._array[i].CompareTo(target) > 0)
            {
                // Linear search backward through the previous block
                for (int j = i - jumpSize + 1; j < i; j++)
                {
                    if (this._array[j].CompareTo(target) == 0)
                    {
                        return j;
                    }
                }

                return -1;
            }
            // Check if the current element is the target
            else if (this._array[i].CompareTo(target) == 0)
            {
                return i;
            }
        }

        // Linear search backward through the last block
        for (int i = this._count - 1; i >= 0; i--)
        {
            if (this._array[i].CompareTo(target) == 0)
            {
                return i;
            }
        }

        // Return -1 if the target is not found
        return -1;
    }

    public string GetCollectionValues()
    {
        StringBuilder values = new StringBuilder();

        foreach (T variable in this._array)
        {
            if (variable is not null)
            {
                values.Append(variable.ToString());
                values.Append(" ");
            }
        }

        return values.ToString();
    }
}