using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.Delete;

public class RegimeDeleteCommandValidator : AbstractValidator<RegimeDeleteCommand>
{
    public RegimeDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id is required");
    }
}
