using FluentValidation;

namespace Contable.Application.Enterprise.Command.Add;

public class EnterpriseAddCommandValidator : AbstractValidator<EnterpriseAddCommand>
{
    public EnterpriseAddCommandValidator()
    {
        RuleFor(x => x.Enterprises)
            .NotNull()
            .NotEmpty()
            .WithMessage("Enterprises is required");
    }
}
