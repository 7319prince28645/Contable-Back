using Contable.Application.Enterprise.Common;
using Contable.Application.Services.Interfaces.Persistence.EnterpriseRepository;
using MediatR;

namespace Contable.Application.Enterprise.Command.UpdateByOne;

public class EnterpriseUpdateOneCommandHandler : IRequestHandler<EnterpriseUpdateOneCommand, EnterpriseResult>
{
    private readonly IEnterpriseCommandRepository _enterpriseCommandRepository;

    public EnterpriseUpdateOneCommandHandler(IEnterpriseCommandRepository enterpriseCommandRepository)
    {
        _enterpriseCommandRepository = enterpriseCommandRepository;
    }

    public async Task<EnterpriseResult> Handle(EnterpriseUpdateOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _enterpriseCommandRepository.UpdateEnterpriseByOne(request.Id, request.Enterprises);
        return new EnterpriseResult(result);
    }
}
