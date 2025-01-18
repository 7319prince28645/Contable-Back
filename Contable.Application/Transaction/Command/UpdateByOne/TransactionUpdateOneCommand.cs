using Contable.Application.Transaction.Common;
using Domain.Transaction;
using MediatR;

namespace Contable.Application.Transaction.Command.UpdateByOne;

public record TransactionUpdateOneCommand(Guid Id, Transactions Transactions) : IRequest<TransactionResult>;
