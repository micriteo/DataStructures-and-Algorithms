namespace FinalAssignment;

public interface ISearchable<T> where T : IComparable
{
    int JumpSearch(InputType target);
}