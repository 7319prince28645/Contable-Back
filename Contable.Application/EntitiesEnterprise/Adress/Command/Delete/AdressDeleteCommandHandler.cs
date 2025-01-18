using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.Delete;

public class AdressDeleteCommandHandler : IRequestHandler<AdressDeleteCommand, string>
{
    private readonly IAdressCommandRepository _adressCommandRepository;

    public AdressDeleteCommandHandler(IAdressCommandRepository adressCommandRepository)
    {
        _adressCommandRepository = adressCommandRepository;
    }

    public async Task<string> Handle(AdressDeleteCommand request, CancellationToken cancellationToken)
    {
        await _adressCommandRepository.DeleteAsync(request.Id);
        return "Adress deleted successfully";
    }
}
