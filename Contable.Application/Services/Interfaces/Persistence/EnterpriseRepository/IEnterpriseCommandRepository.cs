using Contable.Domain.Enterprise;

namespace Contable.Application.Services.Interfaces.Persistence.EnterpriseRepository;

public interface IEnterpriseCommandRepository
{
    Task<Enterprises> AddEnterprise(Enterprises enterprises);
    Task<Enterprises> UpdateEnterprise(Guid id, Enterprises enterprises);
    Task<string> DeleteEnterprise(Guid id);
    Task<Enterprises> UpdateEnterpriseByOne(Guid id, Enterprises enterprises);

}
