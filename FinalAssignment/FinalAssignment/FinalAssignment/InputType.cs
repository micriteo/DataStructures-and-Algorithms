using System.Data;

namespace FinalAssignment;

public class InputType : IComparable
{
    public object value;

    public object Value
    {
        get { return this.value; }
        set
        {
            if (string.IsNullOrEmpty(value.ToString()))
            {
                throw new ArgumentNullException("Value cannot be an empty string");
            }

            try
            {
                double result = double.Parse(value.ToString());

                // Check if the result is a double or an int
                if (result % 1 == 0)
                {
                    this.value = (int)result;
                }
                else
                {
                    this.value = result;
                }
            }
            catch (FormatException e)
            {
                this.value = value.ToString();
            }
        }
    }

    public InputType(string value)
    {
        this.Value = value;
    }

    public int CompareTo(object? obj)
    {
        if (obj is null)
        {
            throw new NoNullAllowedException();
        }

        if (this.Value is string)
        {
            string currentValue = this.Value as string;
            return currentValue.CompareTo(obj);
        }
        else if (obj is int || obj is double)
        {
            return (int)((double)obj - (double)this.Value);
        }

        return 1;
    }

    public override string ToString()
    {
        return value.ToString();
    }
}