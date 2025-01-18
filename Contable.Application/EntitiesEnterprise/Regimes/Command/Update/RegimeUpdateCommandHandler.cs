using Contable.Application.EntitiesEnterprise.Regimes.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.Update;

public class RegimeUpdateCommandHandler : IRequestHandler<RegimeUpdateCommand, RegimeResponse>
{
    private readonly IRegimeCommandRepository _regimeCommandRepository;

    public RegimeUpdateCommandHandler(IRegimeCommandRepository regimeCommandRepository)
    {
        _regimeCommandRepository = regimeCommandRepository;
    }

    public async Task<RegimeResponse> Handle(RegimeUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _regimeCommandRepository.UpdateRegime(request.Id, request.Regime);
        return new RegimeResponse(result);
    }
}
