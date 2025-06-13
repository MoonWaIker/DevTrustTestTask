using Microsoft.EntityFrameworkCore;

namespace DevTrustTestTask.DataBase.Entities;

[PrimaryKey(nameof(Id))]
public sealed record Address
{
    public long Id { get; set; }

    public required string City { get; set; }

    public required string AddressLine { get; set; }
}
