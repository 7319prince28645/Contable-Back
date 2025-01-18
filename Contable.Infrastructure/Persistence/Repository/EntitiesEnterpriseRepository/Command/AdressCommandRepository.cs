using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using Contable.Domain.Enterprise.Entities;

namespace Contable.Infrastructure.Persistence.Repository.EntitiesEnterpriseRepository.Command;

public class AdressCommandRepository : IAdressCommandRepository
{
    private readonly ContextContable _context;

    public AdressCommandRepository(ContextContable context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<Adrress> CreateAsync(Adrress entity)
    {
        if (entity == null)
            throw new Exception("Adress is null");

        await _context.Adrress.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;

    }

    public async Task<Adrress> DeleteAsync(Guid Id)
    {
        var result = await _context.Adrress.FindAsync(Id);
        if (result == null)
            throw new Exception("Adress not found");

        _context.Remove(result);
        await _context.SaveChangesAsync();

        return result;

    }

    public async Task<Adrress> UpdateAsync(Guid Id, Adrress entity)
    {
        var result = await _context.Adrress.FindAsync(Id);
        if (result == null)
            throw new Exception("Adress not found");

        result.Street = entity.Street;
        result.Reference = entity.Reference;
        result.City = entity.City;
        result.State = entity.State;
        result.Country = entity.Country;

        await _context.SaveChangesAsync();

        return result;


    }

    public async Task<Adrress> UpdateByOne(Guid Id, Adrress entity)
    {
        var result = await _context.Adrress.FindAsync(Id);
        if (result == null)
            throw new Exception("Adress not found");

        result.Street = entity.Street ?? result.Street;
        result.Reference = entity.Reference ?? result.Reference;
        result.City = entity.City ?? result.City;
        result.State = entity.State ?? result.State;
        result.Country = entity.Country ?? result.Country;

        await _context.SaveChangesAsync();
        return result;

    }
}
