namespace Dealership.Entities;

public class Car: Entity
{
    public string Brand { get; set;}
    public string Model { get; set;}
    public DateTime Date { get; set; }
    private readonly List<CarSpecification> _specifications = new List<CarSpecification>();
    public IReadOnlyCollection<CarSpecification> Specifications => _specifications.AsReadOnly();
    private Car()
    {
        
    }

    public Car(string brand, string model, DateTime date)
    {
        Id = Guid.NewGuid();
        Brand = brand ?? throw new ArgumentNullException(nameof(brand));
        Model = model ?? throw new ArgumentNullException(nameof(model));
        
        if (date > DateTime.Now)
        {
            throw new ArgumentException("Incorrect date!");
        }
    }
    public void AddSpecification(string detail, string value)
    {
        var specification = new CarSpecification(detail, value);
        _specifications.Add(specification);
    }
}