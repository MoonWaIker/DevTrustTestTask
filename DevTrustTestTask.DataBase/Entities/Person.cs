using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevTrustTestTask.DataBase.Entities;

[PrimaryKey(nameof(Id))]
public record Person
{
    public long Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public long? AddressId { get; set; }

    [ForeignKey(nameof(AddressId))]
    public virtual Address? Address { get; set; }
}
