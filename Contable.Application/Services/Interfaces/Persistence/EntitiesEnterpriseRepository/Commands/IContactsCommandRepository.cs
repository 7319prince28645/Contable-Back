using Contable.Domain.Enterprise.Entities;

namespace Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;

public interface IContactsCommandRepository
{
    Task<Contacts> CreateContacts(Contacts entity);
    Task<Contacts> DeleteContacts(Guid Id);
    Task<Contacts> UpdateContacts(Guid Id, Contacts entity);
    Task<Contacts> UpdateByOneContacts(Guid Id, Contacts entity);

}
