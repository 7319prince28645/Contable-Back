namespace Contable.Domain.Enterprise.Entities;

public class Adrress
{
    public Guid Id { get; init; }
    public string Street { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string? Reference { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public Guid EnterprisesId { get; set; }
}
