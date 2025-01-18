using Contable.Application.EntitiesEnterprise.Contactos.Common;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Contactos.Commands.Add;

public record ContactsAddCommand(Contacts Contacts) : IRequest<ContactsReponse>;
