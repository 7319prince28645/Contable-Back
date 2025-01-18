using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.Add;

public class AdressAddCommandValidator : AbstractValidator<AdressAddCommand>
{
    public AdressAddCommandValidator()
    {
        RuleFor(c => c.Adrress)
            .NotNull()
            .WithMessage("Adrress is required");
    }
}
