using Contable.Application.EntitiesEnterprise.EmployeesC.Commom;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Add;

public record EmployeesCompanyAddCommand(EmployeesCompany EmployeesCompany ) : IRequest<EmployeesCompanyResponse>;
