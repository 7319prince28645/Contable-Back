
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using Contable.Domain.Enterprise.Entities;

namespace Contable.Infrastructure.Persistence.Repository.EntitiesEnterpriseRepository.Command;

public class EmployeesCompanyCommandRepository : IEmployeesCommandRepository
{
    private readonly ContextContable _context;

    public EmployeesCompanyCommandRepository(ContextContable context)
    {
        _context = context;
    }

    public async Task<EmployeesCompany> CreateEmployeesCompany(EmployeesCompany entity)
    {
        await _context.EmployeesCompany.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<EmployeesCompany> DeleteEmployeesCompany(Guid Id)
    {
        var result = await _context.EmployeesCompany.FindAsync(Id)
            ?? throw new Exception("EmployeesCompany not found");

        _context.Remove(result);
        await _context.SaveChangesAsync();

        return result;
    }

    public async Task<EmployeesCompany> UpdateEmployeesCompany(Guid Id, EmployeesCompany entity)
    {
        var result = await _context.EmployeesCompany.FindAsync(Id)
            ?? throw new Exception("EmployeesCompany not found");

        result.Position = entity.Position;
        result.Salary = entity.Salary;

        await _context.SaveChangesAsync();
        return result;

    }

    public async Task<EmployeesCompany> UpdateByOneEmployeesCompany(Guid Id, EmployeesCompany entity)
    {
        var result = await _context.EmployeesCompany.FindAsync(Id)
            ?? throw new Exception("EmployeesCompany not found");

        result.Position = entity.Position ?? result.Position;
        result.Salary = entity.Salary != result.Salary ? entity.Salary : result.Salary;
        await _context.SaveChangesAsync();

        return result;
    }
}
