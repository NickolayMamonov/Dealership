namespace Dealership.Entities;

public class Purchase: Entity
{

    public Buyer Buyer { get;private set; }
    public Car Car { get;private set; }
    public decimal Amount { get;private set; }
    public PaymentDetails PaymentDetails { get; private set; }

    private Purchase()
    {
        
    }

    public Purchase(Buyer buyer, Car car,PaymentDetails paymentDetails, decimal amount) : this()
    {
        Id = Guid.NewGuid();
        Buyer = buyer ?? throw new ArgumentNullException(nameof(buyer));
        Car = car ?? throw new ArgumentNullException(nameof(car));
        PaymentDetails = paymentDetails ?? throw new ArgumentNullException(nameof(paymentDetails));
        Amount = amount >= 0 ? amount : throw new ArgumentOutOfRangeException(nameof(amount));
       
    }
    
    public void UpdatePaymentDetails(string cardNumber, DateTime expiryDate)
    {
        PaymentDetails = new PaymentDetails(cardNumber, expiryDate);
    }
}

