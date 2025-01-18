namespace Contable.Contractx.EnterpriseEntities.Commands.Adress;

public class AdressCreateDTO
{
    public string Street { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string? Reference { get; set; }
    public Guid EnterprisesId { get; set; }
}
