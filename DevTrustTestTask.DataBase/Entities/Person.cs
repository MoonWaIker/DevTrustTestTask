namespace DevTrustTestTask.DataBase.Entities;

public record Person
{
    public long Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public long? AddressId { get; set; }

    public virtual Address? Address { get; set; }
}
