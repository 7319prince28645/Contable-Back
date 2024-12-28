using Contable.Application.Enterprise.Common;
using Contable.Application.Services.Interfaces.Persistence.EnterpriseRepository;
using MediatR;

namespace Contable.Application.Enterprise.Command.Add;

public class EnterpriseAddCommandHandler : IRequestHandler<EnterpriseAddCommand, EnterpriseResult>
{
    private readonly IEnterpriseCommandRepository _enterpriseRepository;

    public EnterpriseAddCommandHandler(IEnterpriseCommandRepository enterpriseRepository)
    {
        _enterpriseRepository = enterpriseRepository;
    }

    public async Task<EnterpriseResult> Handle(EnterpriseAddCommand request, CancellationToken cancellationToken)
    {
        var EnterpriseCommand = await _enterpriseRepository.AddEnterprise(request.Enterprises);
        return new EnterpriseResult(EnterpriseCommand);
    }
}
