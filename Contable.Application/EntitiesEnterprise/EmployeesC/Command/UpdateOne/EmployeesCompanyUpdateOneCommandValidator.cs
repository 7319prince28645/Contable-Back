using Contable.Application.EntitiesEnterprise.EmployeesC.Command.UpdateOne;
using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Add;

public class EmployeesCompanyUpdateOneCommandValidator : AbstractValidator<EmployeesCompanyUpdateOneCommand>
{
    public EmployeesCompanyUpdateOneCommandValidator()
    {
        RuleFor(x => x.EmployeesCompany)
            .NotNull()
            .WithMessage("EmployeesCompany is required");
    }
}
