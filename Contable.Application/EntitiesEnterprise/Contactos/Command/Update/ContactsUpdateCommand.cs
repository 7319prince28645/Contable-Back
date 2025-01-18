using Contable.Application.EntitiesEnterprise.Contactos.Common;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.Update;

public record ContactsUpdateCommand(Guid Id, Contacts Contacts) : IRequest<ContactsReponse>;

