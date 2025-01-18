using Contable.Application.EntitiesEnterprise.Contactos.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.Update;

public class ContactsUpdateCommandHandler : IRequestHandler<ContactsUpdateCommand, ContactsReponse>
{
    private readonly IContactsCommandRepository _contactsCommandRepository;

    public ContactsUpdateCommandHandler(IContactsCommandRepository contactsCommandRepository)
    {
        _contactsCommandRepository = contactsCommandRepository;
    }

    public async Task<ContactsReponse> Handle(ContactsUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _contactsCommandRepository.UpdateContacts(request.Id, request.Contacts);
        return new ContactsReponse(result);
    }
}
