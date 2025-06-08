namespace DevTrustTestTask.Core.Abstractions;

public class PersonBase
{
    public long Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public long? AddressId { get; set; }
}
