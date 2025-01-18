using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.Add;

public class RegimeAddCommandValidator : AbstractValidator<RegimeAddCommand>
{
    public RegimeAddCommandValidator()
    {
        RuleFor(x => x.Regime)
            .NotNull()
            .WithMessage("Regime is required");
     
    }
}
