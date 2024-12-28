using System.Text.Json.Serialization;

namespace Contable.Contractx.Payment.Command;

public class AddPayment
{
    public float Amount { get; set; }
    public float MissingAmount { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }
}

public enum Status
{
    Pending,
    Paid,
    Canceled
}