using Contable.Application.EntitiesEnterprise.Contactos.Commands.Add;
using Contable.Application.EntitiesEnterprise.Contactos.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.Add;

public class ContactsAddCommandHandler : IRequestHandler<ContactsAddCommand, ContactsReponse>
{
    private readonly IContactsCommandRepository _contactsCommandRepository;

    public ContactsAddCommandHandler(IContactsCommandRepository contactsCommandRepository)
    {
        _contactsCommandRepository = contactsCommandRepository;
    }

    public async Task<ContactsReponse> Handle(ContactsAddCommand request, CancellationToken cancellationToken)
    {
        var result = await _contactsCommandRepository.CreateContacts(request.Contacts);
        return new ContactsReponse(result);

    }
}
