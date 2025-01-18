using Contable.Application.EntitiesEnterprise.Contactos.Commands.Add;
using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.Add;

public class ContactsAddCommandValidator : AbstractValidator<ContactsAddCommand>
{
    public ContactsAddCommandValidator()
    {
        RuleFor(c => c.Contacts)
            .NotNull()
            .WithMessage("Contacts is required");
    }
}
