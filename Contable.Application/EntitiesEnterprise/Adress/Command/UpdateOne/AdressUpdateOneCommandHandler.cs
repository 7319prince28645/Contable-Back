using Contable.Application.EntitiesEnterprise.Adress.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.UpdateOne;

public class AdressUpdateOneCommandHandler : IRequestHandler<AdressUpdateOneCommand, AdressResponse>
{
    private readonly IAdressCommandRepository _adressCommandRepository;

    public AdressUpdateOneCommandHandler(IAdressCommandRepository adressCommandRepository)
    {
        _adressCommandRepository = adressCommandRepository;
    }

    public async Task<AdressResponse> Handle(AdressUpdateOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _adressCommandRepository.UpdateByOne(request.Id, request.Adrress);
        return new AdressResponse(result);
    }
}
