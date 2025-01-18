using Contable.Application.Transaction.Common;
using Domain.Transaction;
using MediatR;

namespace Contable.Application.Transaction.Command.Add;

public record TransactionAddCommand(Transactions Transactions) : IRequest<TransactionResult>;
