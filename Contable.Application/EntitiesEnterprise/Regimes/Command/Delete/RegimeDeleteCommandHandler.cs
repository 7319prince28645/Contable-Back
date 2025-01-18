using Contable.Application.EntitiesEnterprise.Regimes.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.Delete;

public class RegimeDeleteCommandHandler : IRequestHandler<RegimeDeleteCommand, string>
{
    private readonly IRegimeCommandRepository _regimeCommandRepository;

    public RegimeDeleteCommandHandler(IRegimeCommandRepository regimeCommandRepository)
    {
        _regimeCommandRepository = regimeCommandRepository;
    }

    public async Task<string> Handle(RegimeDeleteCommand request, CancellationToken cancellationToken)
    {
        var result = await _regimeCommandRepository.DeleteRegime(request.Id);
        return "Regime deleted successfully";
    }
}
