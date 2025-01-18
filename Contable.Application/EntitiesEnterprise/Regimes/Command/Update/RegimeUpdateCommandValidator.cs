using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.Update;

internal class RegimeUpdateCommandValidator : AbstractValidator<RegimeUpdateCommand>
{
    public RegimeUpdateCommandValidator()
    {
        RuleFor(x => x.Regime)
            .NotNull()
            .WithMessage("Regime is required");
    }
}
