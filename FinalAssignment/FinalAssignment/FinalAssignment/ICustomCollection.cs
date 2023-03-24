namespace FinalAssignment;

public interface ICustomCollection<T>
{
    void Add(T obj);
    // void Insert(InputType obj, int index);
    void Clear();
}