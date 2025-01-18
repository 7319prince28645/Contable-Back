using Contable.Contractx.EnterpriseEntities.Commands.EmployeesCompany.Enum;

namespace Contable.Contractx.EnterpriseEntities.Commands.EmployeesCompany;

public class ECUpdateDTO
{
    public string FullName { get; set; } = null!;
    public string Position { get; set; } = null!;
    public required DocumentType DocumentType { get; set; } 
    public int NumberDocument { get; set; }
    public int Salary { get; set; }
    public bool Active { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime ResignationDate { get; set; }
}
