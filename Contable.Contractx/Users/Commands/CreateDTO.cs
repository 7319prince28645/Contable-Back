namespace Contable.Contractx.Users.Commands;

public class CreateDTO
{

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public int Salary { get; set; }
    public bool Planilla { get; set; }

    public DateTime? DatePlanilla { get; set; }
    public DateTime? DateBeginning { get; set; }
}
