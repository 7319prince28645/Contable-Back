using Contable.Domain.Enterprise.Entities;

namespace Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;

public interface IAdressCommandRepository
{
    Task<Adrress> CreateAsync(Adrress entity);
    Task<Adrress> DeleteAsync(Guid Id);
    Task<Adrress> UpdateAsync(Guid Id, Adrress entity);
    Task<Adrress> UpdateByOne(Guid Id, Adrress entity);
}
