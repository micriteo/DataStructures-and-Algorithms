using System.Data;

namespace FinalAssignment;

public class InputType : IComparable
{
    private object _value;

    public object Value
    {
        get
        {
            return this._value;
        }
        private init
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
                    this._value = (int)result;
                }
                else
                {
                    this._value = result;
                }
            }
            catch (FormatException e)
            {
                this._value = value.ToString();
            }
        }
    }

    public InputType(string value)
    {
        this.Value = value;
    }

    public bool IsString()
    {
        return this.Value is string;
    }

    public int CompareTo(object? obj)
    {
        if (obj is null)
        {
            throw new NoNullAllowedException();
        }

        if (IsString())
        {
            string currentValue = this.Value as string;
            return currentValue.CompareTo(obj.ToString());
        }

        if (this.Value is int || this.Value is double)
        {
            try
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
            catch (FormatException e)
            {
                // Based on MY RULES, a string is always smaller than a number
                // Change the number below to 1 if you think I am wrong :)
                return -1;
            }
        }

        throw new ArgumentException("Object is not a string or a number");
    }

    public override string ToString()
    {
        return this.Value.ToString();
    }

    public override bool Equals(object? obj)
    {
        return this.CompareTo(obj) == 0;
    }
}