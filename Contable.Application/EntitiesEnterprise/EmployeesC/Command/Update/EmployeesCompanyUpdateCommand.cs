using Contable.Application.EntitiesEnterprise.EmployeesC.Commom;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Update;


public record EmployeesCompanyUpdateCommand(Guid Id, EmployeesCompany EmployeesCompany) : IRequest<EmployeesCompanyResponse>;
