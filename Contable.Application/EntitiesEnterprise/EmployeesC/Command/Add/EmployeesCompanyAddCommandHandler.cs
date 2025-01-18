using Contable.Application.EntitiesEnterprise.EmployeesC.Commom;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Add;

public class EmployeesCompanyAddCommandHandler : IRequestHandler<EmployeesCompanyAddCommand, EmployeesCompanyResponse>
{
    private readonly IEmployeesCommandRepository _employeesCommandRepository;

    public EmployeesCompanyAddCommandHandler(IEmployeesCommandRepository employeesCommandRepository)
    {
        _employeesCommandRepository = employeesCommandRepository;
    }

    public async Task<EmployeesCompanyResponse> Handle(EmployeesCompanyAddCommand request, CancellationToken cancellationToken)
    {
        await _employeesCommandRepository.CreateEmployeesCompany(request.EmployeesCompany);
        return new EmployeesCompanyResponse(request.EmployeesCompany);
    }
}
