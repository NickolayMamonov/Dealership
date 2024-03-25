namespace Dealership.Entities;

public class Car: Entity
{
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
    public string Brand { get; set;}
    public string Model { get; set;}
    public DateTime Date { get; set; }
}