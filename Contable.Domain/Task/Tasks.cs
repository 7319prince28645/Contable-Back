using Domain.Transaction;

namespace Contable.Domain.Task;

public sealed class Tasks
{
    public Guid Id { get; init; }
    public bool IsTerminated { get;  set; }
    public DateTime? CreatedAt { get;  set; }
    public DateTime? UpdatedAt { get;  set; }

    public Guid? TransactionsId { get; private set; }
    public Transactions? Transactions { get; private set; }

}
