using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.Delete;

public class ContactsDeleteCommandHandler : IRequestHandler<ContactsDeleteCommand, string>
{
    private readonly IContactsCommandRepository _contactsCommandRepository;

    public ContactsDeleteCommandHandler(IContactsCommandRepository contactsCommandRepository)
    {
        _contactsCommandRepository = contactsCommandRepository;
    }

    public async Task<string> Handle(ContactsDeleteCommand request, CancellationToken cancellationToken)
    {
        await _contactsCommandRepository.DeleteContacts(request.Id);
        return "Contact deleted successfully";
    }
}
