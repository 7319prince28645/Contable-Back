using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.UpdateOne;

public class AdressUpdateOneCommandValidator : AbstractValidator<AdressUpdateOneCommand>
{
    public AdressUpdateOneCommandValidator()
    {
        RuleFor(c => c.Id)
            .NotNull()
            .WithMessage("Id is required");
        RuleFor(c => c.Adrress)
            .NotNull()
            .WithMessage("Adrress is required");
    }

}
