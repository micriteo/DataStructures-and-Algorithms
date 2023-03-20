namespace FinalAssignment;

public class CustomArrayList<T>:ISortable, ISearchable,IInsertable
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
        throw new NotImplementedException();
    }

    public InputType[] InsertSort()
    {
        throw new NotImplementedException();
    }

    public void Insert(InputType obj)
    {
        // TODO: When array reaches capacity limit, increase the size of the array by the incrementer and keep the old values
        throw new NotImplementedException();
    }
}