using System.ComponentModel.DataAnnotations.Schema;

namespace Contable.Contractx.Transaction.Command;

public class TransactionAdd
{
    public TransactionName TransactionName { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    public bool ReemSales { get; set; }
    public bool IsTerminated { get; set; }
    public string? Description { get; set; }
    public string? Period { get; set; }
}

public enum TransactionName
{
    Bills,
    Sales
}