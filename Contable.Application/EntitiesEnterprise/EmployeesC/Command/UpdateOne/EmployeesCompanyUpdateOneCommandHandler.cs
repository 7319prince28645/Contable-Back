using Contable.Application.EntitiesEnterprise.EmployeesC.Commom;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.UpdateOne;

public class EmployeesCompanyUpdateOneCommandHandler : IRequestHandler<EmployeesCompanyUpdateOneCommand, EmployeesCompanyResponse>
{
    private readonly IEmployeesCommandRepository _employeesCommandRepository;

    public EmployeesCompanyUpdateOneCommandHandler(IEmployeesCommandRepository employeesCommandRepository)
    {
        _employeesCommandRepository = employeesCommandRepository;
    }

    public async Task<EmployeesCompanyResponse> Handle(EmployeesCompanyUpdateOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _employeesCommandRepository.UpdateByOneEmployeesCompany(request.Id, request.EmployeesCompany);
        return new EmployeesCompanyResponse(result);
    }
}
