using Domain.Transaction;

namespace Domain.Statement;

public sealed class Statements
{
    public Guid Id { get; init; }
    public DateTime DateStatement { get; set; }
    public Guid? DateTaxReturnsId { get; set; }
    public Guid? TransactionsId { get; set; }
    public Transactions? Transactions { get; set; }
}
