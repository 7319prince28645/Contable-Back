using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Delete;

public class EmployeesCompanyDeleteCommandHandler : IRequestHandler<EmployeesCompanyDeleteCommand, string>
{
    private readonly IEmployeesCommandRepository _employeesCommandRepository;

    public EmployeesCompanyDeleteCommandHandler(IEmployeesCommandRepository employeesCommandRepository)
    {
        _employeesCommandRepository = employeesCommandRepository;
    }

    public async Task<string> Handle(EmployeesCompanyDeleteCommand request, CancellationToken cancellationToken)
    {
        await _employeesCommandRepository.DeleteEmployeesCompany(request.Id);
        return "Delete sucessly";

    }
}
