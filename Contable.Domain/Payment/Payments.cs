using Domain.Payment.Enum;

namespace Domain.Payment;

public sealed class Payments 
{
    public Guid Id { get; init; }
    public float Amount { get;  set; }
    public float MissingAmount { get;  set; }
    public Status Status { get;  set; }
    public DateTime? CreatedAt { get;  set; } = DateTime.Now;
    public DateTime? UpdatedAt { get;  set; }

}
