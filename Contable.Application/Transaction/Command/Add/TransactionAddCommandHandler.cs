using Contable.Application.Services.Interfaces.Persistence.TransactionRepository;
using Contable.Application.Transaction.Common;
using MediatR;

namespace Contable.Application.Transaction.Command.Add;

public class TransactionAddCommandHandler : IRequestHandler<TransactionAddCommand, TransactionResult>
{
    private readonly ITransactionCommandRepository _transactionCommandRepository;

    public TransactionAddCommandHandler(ITransactionCommandRepository transactionCommandRepository)
    {
        _transactionCommandRepository = transactionCommandRepository;
    }

    public async Task<TransactionResult> Handle(TransactionAddCommand request, CancellationToken cancellationToken)
    {
        var result = await _transactionCommandRepository.CreateTransaction(request.Transactions);
        return new TransactionResult(result);
    }
}
