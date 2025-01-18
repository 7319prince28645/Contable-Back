using Contable.Domain.Enterprise.Entities;

namespace Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;

public interface IRegimeCommandRepository
{
    Task<Regime> CreateRegime(Regime entity);
    Task<Regime> DeleteRegime(Guid Id);
    Task<Regime> UpdateRegime(Guid Id, Regime entity);
    Task<Regime> UpdateByOneRegime(Guid Id, Regime entity);
}
