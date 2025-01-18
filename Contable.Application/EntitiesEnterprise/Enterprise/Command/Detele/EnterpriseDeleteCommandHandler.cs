using Contable.Application.Services.Interfaces.Persistence.EnterpriseRepository;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Enterprise.Command.Detele;

public class EnterpriseDeleteCommandHandler : IRequestHandler<EnterpriseDeleteCommand, string>
{
    private readonly IEnterpriseCommandRepository _enterpriseCommandRepository;

    public EnterpriseDeleteCommandHandler(IEnterpriseCommandRepository enterpriseCommandRepository)
    {
        _enterpriseCommandRepository = enterpriseCommandRepository;
    }

    public async Task<string> Handle(EnterpriseDeleteCommand request, CancellationToken cancellationToken)
    {
        return await _enterpriseCommandRepository.DeleteEnterprise(request.Id);
    }
}
