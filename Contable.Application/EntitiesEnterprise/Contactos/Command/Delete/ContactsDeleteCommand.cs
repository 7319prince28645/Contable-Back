using MediatR;

namespace Contable.Application.EntitiesEnterprise.Contactos.Command.Delete;

public record ContactsDeleteCommand(Guid Id) : IRequest<string>;
