namespace Dealership.Entities;

public class Purchase: Entity
{

    public Buyer Buyer { get; set; }
    public Car Car { get; set; }
    public decimal Amount { get; set; }

    private Purchase()
    {
        
    }

    public Purchase(Buyer buyer, Car car, decimal amount) : this()
    {
        Id = Guid.NewGuid();
        Buyer = buyer ?? throw new ArgumentNullException(nameof(buyer));
        Car = car ?? throw new ArgumentNullException(nameof(car));
        Amount = amount >= 0 ? amount : throw new ArgumentOutOfRangeException(nameof(amount));
       
    }
}

