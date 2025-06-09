namespace DevTrustTestTask.DataBase.Entities;

public record Address
{
    public long Id { get; set; }

    public required string City { get; set; }

    public required string AddressLine { get; set; }
}
