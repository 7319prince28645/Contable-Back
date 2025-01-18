
using Contable.Application.EntitiesEnterprise.EmployeesC.Commom;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Update;

public class EmployeesCompanyUpdateCommandHandler : IRequestHandler<EmployeesCompanyUpdateCommand, EmployeesCompanyResponse>
{
    private readonly IEmployeesCommandRepository _employeesCompanyCommandRepository;

    public EmployeesCompanyUpdateCommandHandler(IEmployeesCommandRepository employeesCompanyCommandRepository)
    {
        _employeesCompanyCommandRepository = employeesCompanyCommandRepository;
    }

    public async Task<EmployeesCompanyResponse> Handle(EmployeesCompanyUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _employeesCompanyCommandRepository.UpdateEmployeesCompany(request.Id, request.EmployeesCompany);
        return new EmployeesCompanyResponse(result);

    }
}
