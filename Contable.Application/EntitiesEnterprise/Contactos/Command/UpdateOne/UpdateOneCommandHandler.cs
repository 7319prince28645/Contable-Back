using Contable.Application.EntitiesEnterprise.Contactos.Common;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.UpdateOne;

public class UpdateOneCommandHandler : IRequestHandler<UpdateOneCommand, ContactsReponse>
{
    private readonly IContactsCommandRepository _contactCommandRepository;

    public UpdateOneCommandHandler(IContactsCommandRepository contactCommandRepository)
    {
        _contactCommandRepository = contactCommandRepository;
    }

    public async Task<ContactsReponse> Handle(UpdateOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _contactCommandRepository.UpdateByOneContacts(request.Id, request.Contacts);
        return new ContactsReponse(result);

    }
}
