namespace DevTrustTestTask.Infrastructure.DTO;

public sealed record GetAllRequest
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;
}
