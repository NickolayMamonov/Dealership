namespace Dealership.Entities;

public class CarSpecification : ValueObject
{
    public string Detail { get; private set; }
    public string Value { get; private set; }

    public CarSpecification(string detail, string value)
    {
        Detail = detail ?? throw new ArgumentNullException(nameof(detail));
        Value = value ?? throw new ArgumentNullException(nameof(value));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Detail;
        yield return Value;
    }
}