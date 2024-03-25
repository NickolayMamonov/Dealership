namespace Dealership.Entities;

public class PaymentDetails : ValueObject
{
    public string CardNumber { get; private set; }
    public DateTime ExpiryDate { get; private set; }

    public PaymentDetails(string cardNumber, DateTime expiryDate)
    {
        CardNumber = cardNumber ?? throw new ArgumentNullException(nameof(cardNumber));
        if (cardNumber.Length != 16)
            throw new ArgumentException("Card number must be 16 digits long.");
        ExpiryDate = expiryDate > DateTime.Now ? expiryDate : throw new ArgumentException("Expiry date incorrect.");
    }

  

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return CardNumber;
        yield return ExpiryDate;
    }
}