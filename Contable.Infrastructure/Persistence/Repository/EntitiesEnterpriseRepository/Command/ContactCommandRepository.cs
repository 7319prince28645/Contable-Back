using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using Contable.Domain.Enterprise.Entities;

namespace Contable.Infrastructure.Persistence.Repository.EntitiesEnterpriseRepository.Command;

public class ContactCommandRepository : IContactsCommandRepository
{
    private readonly ContextContable _context;

    public ContactCommandRepository(ContextContable context)
    {
        _context = context;
    }

    public async Task<Contacts> CreateContacts(Contacts entity)
    {
        await _context.Contacts.AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<Contacts> DeleteContacts(Guid Id)
    {
        var result = await _context.Contacts.FindAsync(Id)
            ?? throw new Exception("Contact not found");

        _context.Remove(result);
        await _context.SaveChangesAsync();
        return result;
    }

    public async Task<Contacts> UpdateContacts(Guid Id, Contacts entity)
    {
        var result = await _context.Contacts.FindAsync(Id)
            ?? throw new Exception("Contact not found");

        result.Name = entity.Name;
        result.Phone = entity.Phone;

        await _context.SaveChangesAsync();

        return result;

    }

    public async Task<Contacts> UpdateByOneContacts(Guid Id, Contacts entity)
    {
        var result = await _context.Contacts.FindAsync(Id)
            ?? throw new Exception("Contact not found");

        result.Name = entity.Name ?? result.Name;
        result.Phone = entity.Phone ?? result.Phone;

        await _context.SaveChangesAsync();

        return result;
    }
}
