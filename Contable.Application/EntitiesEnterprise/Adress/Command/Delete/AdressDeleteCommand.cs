using MediatR;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.Delete;

public record AdressDeleteCommand(Guid Id) : IRequest<string>;
