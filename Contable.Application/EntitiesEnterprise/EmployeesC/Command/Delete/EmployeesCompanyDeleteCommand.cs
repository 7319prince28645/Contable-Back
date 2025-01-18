using MediatR;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Delete;


public record EmployeesCompanyDeleteCommand(Guid Id) : IRequest<string>;
