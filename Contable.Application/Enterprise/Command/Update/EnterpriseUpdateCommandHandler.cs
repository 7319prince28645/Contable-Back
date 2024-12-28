using Contable.Application.Enterprise.Common;
using Contable.Application.Services.Interfaces.Persistence.EnterpriseRepository;
using MediatR;

namespace Contable.Application.Enterprise.Command.Update;

public class EnterpriseUpdateCommandHandler : IRequestHandler<EnterpriseUpdateCommand, EnterpriseResult>
{
    private readonly IEnterpriseCommandRepository _enterpriseRepository;

    public EnterpriseUpdateCommandHandler(IEnterpriseCommandRepository enterpriseRepository)
    {
        _enterpriseRepository = enterpriseRepository;
    }

    public async Task<EnterpriseResult> Handle(EnterpriseUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _enterpriseRepository.UpdateEnterprise(request.Id, request.Enterprise);
        return new EnterpriseResult(result);
    }
}
