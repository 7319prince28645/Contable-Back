using Contable.Domain.Enterprise;
using Contable.Domain.Task;
using Domain.Payment;
using Domain.Transaction;

namespace Contable.Domain.User;

public sealed class Users
{
    public Guid Id { get; init; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public int Salary { get; set; }
    public bool Planilla { get; set; }

    public DateTime? DatePlanilla { get; set; }
    public DateTime? DateBeginning { get; set; }
    public DateTime? DateEndEnterprise { get; set; }
    public DateTime CreatedDateTime { get; set; } 
    public DateTime UpdatedDateTime { get; set; } 

    public Guid? TasksId { get; set; }
    public Guid? TransactionsId { get; set; }
    public Guid? PaymentsId { get; set; }

    public Tasks? Tasks { get; set; }
    public Transactions? Transactions { get; set; }
    public Payments? Payments { get; set; }

    public List<Enterprises>? Enterprises { get; set; } = [];

}
