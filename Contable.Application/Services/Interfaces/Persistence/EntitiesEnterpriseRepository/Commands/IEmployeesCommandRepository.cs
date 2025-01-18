using Contable.Domain.Enterprise.Entities;

namespace Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;

public interface IEmployeesCommandRepository
{
    Task<EmployeesCompany> CreateEmployeesCompany(EmployeesCompany entity);
    Task<EmployeesCompany> DeleteEmployeesCompany(Guid Id);
    Task<EmployeesCompany> UpdateEmployeesCompany(Guid Id, EmployeesCompany entity);
    Task<EmployeesCompany> UpdateByOneEmployeesCompany(Guid Id, EmployeesCompany entity);

}
