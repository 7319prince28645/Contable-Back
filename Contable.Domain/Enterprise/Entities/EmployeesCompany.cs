using Contable.Domain.Enterprise.Enum;

namespace Contable.Domain.Enterprise.Entities;

public class EmployeesCompany
{
    public Guid Id { get; init; }
    public string FullName { get; set; } = null!;
    public string Position { get; set; } = null!;
    public DocumentType DocumentType { get; set; }
    public int NumberDocument { get; set; }
    public int Salary { get; set; }
    public bool Active { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime ResignationDate { get; set; }

}
