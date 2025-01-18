using MediatR;

namespace Contable.Application.Statement.Command.Delete;

public record StatementDeleteCommand(Guid Id) : IRequest<string>;

