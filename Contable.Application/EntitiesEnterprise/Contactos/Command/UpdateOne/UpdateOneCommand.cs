using Contable.Application.EntitiesEnterprise.Contactos.Common;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.UpdateOne;

public record UpdateOneCommand(Guid Id, Contacts Contacts) : IRequest<ContactsReponse>;
