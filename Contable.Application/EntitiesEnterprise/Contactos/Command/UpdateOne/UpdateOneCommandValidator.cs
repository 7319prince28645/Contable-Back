using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.UpdateOne;

public class UpdateOneCommandValidator : AbstractValidator<UpdateOneCommand>
{
    public UpdateOneCommandValidator()
    {
        RuleFor(c => c.Id)
            .NotNull()
            .WithMessage("Id is required");
        RuleFor(c => c.Contacts)
            .NotNull()
            .WithMessage("Contacts is required");
    }
}
