using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.UpdateOne;

public class RegimeUpdateOneCommandValidator : AbstractValidator<RegimeUpdateOneCommand>
{
    public RegimeUpdateOneCommandValidator()
    {
        RuleFor(x => x.Regime)
            .NotNull()
            .WithMessage("Regime is required");
    }
}
