using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.Update;

public class ContactsUpdateCommandValidator : AbstractValidator<ContactsUpdateCommand>
{
    public ContactsUpdateCommandValidator()
    {
        RuleFor(c => c.Id)
            .NotNull()
            .WithMessage("Id is required");
        RuleFor(c => c.Contacts)
            .NotNull()
            .WithMessage("Contacts is required");
    }
}
