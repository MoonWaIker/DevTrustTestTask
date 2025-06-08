namespace DevTrustTestTask.Core.Abstractions;

public class AddressBase
{
    public long Id { get; set; }

    public required string City { get; set; }

    public required string AddressLine { get; set; }
}
