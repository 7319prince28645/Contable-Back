using MediatR;

namespace Contable.Application.Task.Command.Delete;

public record TaskDeleteCommand(Guid Id) : IRequest<string>;
