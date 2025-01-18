using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.Update;

public class AdressUpdateCommandValidator : AbstractValidator<AdressUpdateCommand>
{
    public AdressUpdateCommandValidator()
    {
        RuleFor(c => c.Id)
            .NotNull()
            .WithMessage("Id is required");

        RuleFor(c=>c.Adrress)
            .NotNull()
            .WithMessage("Adrress is required");


    }
}
