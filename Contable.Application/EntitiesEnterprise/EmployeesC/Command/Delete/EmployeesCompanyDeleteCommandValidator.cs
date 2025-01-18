using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.EmployeesC.Command.Delete;


public class EmployeesCompanyDeleteCommandValidator : AbstractValidator<EmployeesCompanyDeleteCommand>
{
    public EmployeesCompanyDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id is required");
    }
}
