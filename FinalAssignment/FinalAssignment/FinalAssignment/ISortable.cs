namespace FinalAssignment;

public interface ISortable<T> where T : IComparable
{ 
    T[] MergeSort();
    T[] QuickSort();
    int JumpSearch(InputType target);
}