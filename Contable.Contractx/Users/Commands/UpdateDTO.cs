﻿namespace Contable.Contractx.Users.Commands;

public class UpdateDTO
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public int Salary { get; set; }
    public bool Planilla { get; set; }

    public DateTime? DatePlanilla { get; set; }
    public DateTime? DateBeginning { get; set; }
    public DateTime? DateEndEnterprise { get; set; }
    public DateTime UpdatedDateTime { get; set; } = DateTime.Now;
}
