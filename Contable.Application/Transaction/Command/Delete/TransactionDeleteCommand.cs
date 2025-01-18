using MediatR;

namespace Contable.Application.Transaction.Command.Delete;

public record TransactionDeleteCommand(Guid Id) : IRequest<string>;
