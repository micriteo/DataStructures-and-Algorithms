using System.Data;

namespace FinalAssignment;

public class InputType : IComparable
{
    public object value;

    public object Value
    {
        get
        {
            return this.value;
        }
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
            return currentValue.CompareTo(obj.ToString());
        }

        if (this.Value is int || this.Value is double)
        {
            double result = Double.Parse(obj.ToString()) - Double.Parse(this.Value.ToString());

            // Return -1 if the result is less than 0, 1 if the result is greater than 0, and 0 if the result is 0
            return result switch
            {
                < 0 => -1,
                > 0 => 1,
                _ => 0
            };
        }

        throw new ArgumentException("Object is not a string or a number");
    }

    public override string ToString()
    {
        return value.ToString();
    }
}