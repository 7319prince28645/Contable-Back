using Domain.Payment.Enum;

namespace Domain.Payment;

public sealed class Payments 
{
    public Guid Id { get; init; }
    public float Amount { get; private set; }
    public float MissingAmount { get; private set; }
    public Status Status { get; private set; }
    public DateTime? CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

}
