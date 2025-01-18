using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using Contable.Domain.Enterprise.Entities;

namespace Contable.Infrastructure.Persistence.Repository.EntitiesEnterpriseRepository.Command;

public class RegimeCommandRepository : IRegimeCommandRepository
{
    private readonly ContextContable _context;

    public RegimeCommandRepository(ContextContable context)
    {
        _context = context;
    }

    public async Task<Regime> CreateRegime(Regime entity)
    {
        await _context.Regime.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Regime> DeleteRegime(Guid Id)
    {
        var result = await _context.Regime.FindAsync(Id)
            ?? throw new Exception("Regime not found");

        _context.Remove(result);
        await _context.SaveChangesAsync();
        return result;
    }

    public async Task<Regime> UpdateRegime(Guid Id, Regime entity)
    {
        var result = await _context.Regime.FindAsync(Id)
            ?? throw new Exception("Regime not found");

        result.Name = entity.Name;
        result.PercentageMonth = entity.PercentageMonth;

        await _context.SaveChangesAsync();

        return result;
    }

    public async Task<Regime> UpdateByOneRegime(Guid Id, Regime entity)
    {
        var result = await _context.Regime.FindAsync(Id)
            ?? throw new Exception("Regime not found");

        result.Name = entity.Name ?? result.Name;
        result.PercentageMonth = entity.PercentageMonth != result.PercentageMonth ? entity.PercentageMonth : result.PercentageMonth;

        await _context.SaveChangesAsync();
        return result;
    }
}
