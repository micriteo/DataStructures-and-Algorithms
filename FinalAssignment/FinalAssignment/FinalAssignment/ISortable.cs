namespace FinalAssignment;

public interface ISortable<T> where T : IComparable
{ 
    T[] QuickSort();
    T[] InsertSort();
}