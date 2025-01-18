using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Update;

public class EmployeesCompanyUpdateCommandValidator : AbstractValidator<EmployeesCompanyUpdateCommand>
{
    public EmployeesCompanyUpdateCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id is required");
        RuleFor(x => x.EmployeesCompany)
            .NotNull()
            .WithMessage("EmployeesCompany is required");
    }
}
