namespace Contable.Domain.Enterprise.Entities;

public class Contacts
{
    public Guid Id { get; init; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Role { get; set; }

}
