namespace Contable.Domain.Enterprise.Entities;

public class Regime
{
    public Guid Id { get; init; }
    public string? Name { get; set; }
    public float? PercentageMonth { get; set; }
    public Guid EnterprisesId { get; set; }

}
