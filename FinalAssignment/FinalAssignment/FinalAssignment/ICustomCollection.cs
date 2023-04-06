namespace FinalAssignment;

public interface ICustomCollection<T>
{
    void Add(T value);
    // void Insert(InputType value, int index);
    void Clear();
    string GetCollectionValues();
}