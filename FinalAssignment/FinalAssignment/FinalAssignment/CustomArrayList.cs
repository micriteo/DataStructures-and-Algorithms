using System;

namespace FinalAssignment;

public class CustomArrayList<T> : ISortable, ISearchable, IInsertable<T> where T : InputType
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

        // if (left < right)
        // {
        //     int pivotIndex = Partition(_array, left, right);
        //     Swap(_array, left, pivotIndex - 1);
        //     Swap(_array, pivotIndex + 1, right);
        // }


        throw new NotImplementedException();
    }

    private T[] Swap(T[] _array, int i, int j)
    {
        T temp = _array[i];
        _array[i] = _array[j];
        _array[j] = temp;
        return _array;
    }
   
    /*private int Partition(T[] _array, int left, int right)
    {
        T pivot = _array[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (Comparer<T>.Default.Compare(_array[j], pivot) < 0)
            {
                i++;
                Swap(_array, i, j);
            }
        }
        Swap(_array, i + 1, right);
        return i + 1;
    }*/

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

        this._array[_count] = item;
        this._count++;
    }
}