using Contable.Application.EntitiesEnterprise.Adress.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.Update;

public class AdressUpdateCommandHandler : IRequestHandler<AdressUpdateCommand, AdressResponse>
{
    private readonly IAdressCommandRepository _adressCommandRepository;

    public AdressUpdateCommandHandler(IAdressCommandRepository adressCommandRepository)
    {
        _adressCommandRepository = adressCommandRepository;
    }

    public async Task<AdressResponse> Handle(AdressUpdateCommand request, CancellationToken cancellationToken)
    {
       var result = await _adressCommandRepository.UpdateAsync(request.Id, request.Adrress);
        return new AdressResponse(result);
    }
}
