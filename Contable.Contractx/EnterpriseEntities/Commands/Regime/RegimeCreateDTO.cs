namespace Contable.Contractx.EnterpriseEntities.Commands.Regime;

public class RegimeCreateDTO
{
    public string? Name { get; set; }
    public float? PercentageMonth { get; set; }
    public Guid EnterprisesId { get; set; }
}
