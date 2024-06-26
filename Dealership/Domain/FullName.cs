﻿namespace Dealership.Entities;

public class FullName:ValueObject
{
    public string FirstName { get; }
    public string LastName { get; }
    public FullName(string firstName, string lastName)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FirstName;
        yield return LastName;
    }
}