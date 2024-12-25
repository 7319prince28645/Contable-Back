using Domain.Transaction.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Transaction;

public sealed class Transactions
{
    public Guid Id { get; init; }
    public TransactionName TransactionName { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    public bool ReemSales { get; set; }
    public bool IsTerminated { get; set; }
    public string? Description { get; set; }
    public string? Period { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

}
