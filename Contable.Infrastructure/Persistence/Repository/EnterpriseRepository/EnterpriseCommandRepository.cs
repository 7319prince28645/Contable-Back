using Contable.Application.Services.Interfaces.Persistence.EnterpriseRepository;
using Contable.Domain.Enterprise;
using Microsoft.EntityFrameworkCore;

namespace Contable.Infrastructure.Persistence.Repository.EnterpriseRepository;

public class EnterpriseCommandRepository : IEnterpriseCommandRepository
{
    private readonly ContextContable _context;

    public EnterpriseCommandRepository(ContextContable context)
    {
        _context = context;
    }

    public async Task<Enterprises> AddEnterprise(Enterprises enterprises)
    {
        var RucEnterprise = await _context.Enterprises.AnyAsync(e => e.Ruc == enterprises.Ruc);
        if (RucEnterprise)
            throw new Exception("Enterprise already exists");

        _context.Enterprises.Add(enterprises);
        await _context.SaveChangesAsync();
        return enterprises;
    }

    public async Task<string> DeleteEnterprise(Guid id)
    {
        var enterprise = await _context.Enterprises.FindAsync(id);
        if (enterprise == null)
            throw new Exception("Enterprise not found");

        _context.Enterprises.Remove(enterprise);
        await _context.SaveChangesAsync();
        return "Enterprise deleted";
    }

    public async Task<Enterprises> UpdateEnterprise(Guid id, Enterprises enterprises)
    {
        var enterprise = await _context.Enterprises.FindAsync(id);
        if (enterprise == null)
            throw new Exception("Enterprise not found");

        enterprise.Planilla = enterprises.Planilla;
        enterprise.CompanyName = enterprises.CompanyName;
        enterprise.Ruc = enterprises.Ruc;

        await _context.SaveChangesAsync();
        return enterprise;
    }

    public async Task<Enterprises> UpdateEnterpriseByOne(Guid id, Enterprises enterprises)
    {
        var enterprise = _context.Enterprises.Find(id);
        if (enterprise == null)
            throw new Exception("Enterprise not found");

        if (enterprises.Planilla != enterprise.Planilla)
            enterprise.Planilla = enterprises.Planilla;
        if (!string.IsNullOrEmpty(enterprises.CompanyName))
            enterprise.CompanyName = enterprises.CompanyName;
        if (!string.IsNullOrEmpty(enterprises.Ruc))
            enterprise.Ruc = enterprises.Ruc;

        await _context.SaveChangesAsync();
        return enterprise;
    }
}
