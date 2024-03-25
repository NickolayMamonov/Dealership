namespace Dealership.Entities;

public class PhoneNum: ValueObject
{
    public string Value { get; }
    public PhoneNum(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value));
        }

        if (value.Length != 11)
        {
            throw new ArgumentOutOfRangeException("PhoneNum value is incorrect");
        }
        //more validations
        Value = value;
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}