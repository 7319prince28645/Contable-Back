using MediatR;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.Delete;

public record RegimeDeleteCommand(Guid Id) : IRequest<string>;
