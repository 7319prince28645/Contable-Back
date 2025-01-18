using Contable.Application.Transaction.Common;
using Domain.Transaction;
using MediatR;

namespace Contable.Application.Transaction.Command.Update;

public record TransactionUpdateCommand(Guid Id, Transactions Transactions) : IRequest<TransactionResult>;
