using MediatR;

namespace Contable.Application.Authentication.Command.Delete;

public record DeleteByIdCommand(Guid id) : IRequest<string>;

