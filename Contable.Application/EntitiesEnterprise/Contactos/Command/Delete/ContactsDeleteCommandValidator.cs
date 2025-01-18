using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.Delete;

public class ContactsDeleteCommandValidator : AbstractValidator<ContactsDeleteCommand>
{
    public ContactsDeleteCommandValidator()
    {
        RuleFor(c => c.Id)
            .NotNull()
            .WithMessage("Id is required");
    }
}
