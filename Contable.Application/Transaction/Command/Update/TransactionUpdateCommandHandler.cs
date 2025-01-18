using Contable.Application.Services.Interfaces.Persistence.TransactionRepository;
using Contable.Application.Transaction.Common;
using MediatR;

namespace Contable.Application.Transaction.Command.Update;

public class TransactionUpdateCommandHandler : IRequestHandler<TransactionUpdateCommand, TransactionResult>
{
    private readonly ITransactionCommandRepository _transactionCommandRepository;

    public TransactionUpdateCommandHandler(ITransactionCommandRepository transactionCommandRepository)
    {
        _transactionCommandRepository = transactionCommandRepository;
    }

    public async Task<TransactionResult> Handle(TransactionUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _transactionCommandRepository.UpdateTransaction(request.Id, request.Transactions);
        return new TransactionResult(result);
    }
}
