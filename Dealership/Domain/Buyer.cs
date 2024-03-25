namespace Dealership.Entities;

public class Buyer: Entity
{
    public FullName FullName { get; private set; }
    public PhoneNum PhoneNum { get; private set; }
    public readonly List<Purchase> _purchases;
    public IReadOnlyCollection<Purchase> Purchases => _purchases.AsReadOnly();
    
    private Buyer()
    {
        
    }

    public Buyer(FullName fullName) : this()
    {
        Id = Guid.NewGuid();
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        _purchases = new List<Purchase>();
    }
    
 
}