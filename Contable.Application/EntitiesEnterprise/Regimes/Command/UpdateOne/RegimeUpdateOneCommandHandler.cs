using Contable.Application.EntitiesEnterprise.Regimes.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.UpdateOne;

public class RegimeUpdateOneCommandHandler : IRequestHandler<RegimeUpdateOneCommand, RegimeResponse>
{
    private readonly IRegimeCommandRepository _regimeCommandRepository;

    public RegimeUpdateOneCommandHandler(IRegimeCommandRepository regimeCommandRepository)
    {
        _regimeCommandRepository = regimeCommandRepository;
    }

    public async Task<RegimeResponse> Handle(RegimeUpdateOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _regimeCommandRepository.UpdateByOneRegime(request.Id, request.Regime);
        return new RegimeResponse(result);  
    }
}
