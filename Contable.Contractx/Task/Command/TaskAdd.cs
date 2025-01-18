namespace Contable.Contractx.Task.Command;

public class TaskAdd
{
    public bool IsTerminated { get; set; }
    public Guid? TransactionsId { get; private set; }
}
