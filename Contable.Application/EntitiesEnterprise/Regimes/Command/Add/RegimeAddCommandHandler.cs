using Contable.Application.EntitiesEnterprise.Regimes.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.Add;

public class RegimeAddCommandHandler : IRequestHandler<RegimeAddCommand, RegimeResponse>
{
    private readonly IRegimeCommandRepository _regimeCommandRepository;

    public RegimeAddCommandHandler(IRegimeCommandRepository regimeCommandRepository)
    {
        _regimeCommandRepository = regimeCommandRepository;
    }

    public async Task<RegimeResponse> Handle(RegimeAddCommand request, CancellationToken cancellationToken)
    {
        var result = await _regimeCommandRepository.CreateRegime(request.Regime);
        return new RegimeResponse(result);
    }
}
