using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Add;

public class EmployeesCompanyAddCommandValidator : AbstractValidator<EmployeesCompanyAddCommand>
{
    public EmployeesCompanyAddCommandValidator()
    {
        RuleFor(x => x.EmployeesCompany)
            .NotNull()
            .WithMessage("EmployeesCompany is required");
    }
}
