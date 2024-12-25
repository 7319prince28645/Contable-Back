using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ExchangeRate;

public sealed class ExchangeRates
{
    public Guid Id { get; init; }
    public DateTime Date { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal BuyRate { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal SellRate { get; set; }
}
