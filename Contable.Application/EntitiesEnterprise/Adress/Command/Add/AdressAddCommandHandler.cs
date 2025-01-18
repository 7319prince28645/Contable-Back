using Contable.Application.EntitiesEnterprise.Adress.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.Add;

public class AdressAddCommandHandler : IRequestHandler<AdressAddCommand, AdressResponse>
{
    private readonly IAdressCommandRepository _adressCommandRepository;

    public AdressAddCommandHandler(IAdressCommandRepository adressCommandRepository)
    {
        _adressCommandRepository = adressCommandRepository;
    }

    public async Task<AdressResponse> Handle(AdressAddCommand request, CancellationToken cancellationToken)
    {
       var result = await _adressCommandRepository.CreateAsync(request.Adrress);
        return new AdressResponse(result);
    }
}
