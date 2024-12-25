using Domain.Statement;

namespace Domain.DateTaxReturn;

public class DateTaxReturns
{
    public Guid Id { get; set; }
    public DateTime Date { get;  set; }
    public int DigitRuc { get;  set; }

    public Statements? Statements { get;  set; }

}
