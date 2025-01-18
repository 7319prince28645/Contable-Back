using Contable.Application.Services.Interfaces.Persistence.TransactionRepository;
using Contable.Application.Transaction.Common;
using MediatR;

namespace Contable.Application.Transaction.Command.UpdateByOne;

public class TransactionUpdateOneCommandHandler : IRequestHandler<TransactionUpdateOneCommand, TransactionResult>
{
    private readonly ITransactionCommandRepository _transactionCommandRepository;

    public TransactionUpdateOneCommandHandler(ITransactionCommandRepository transactionCommandRepository)
    {
        _transactionCommandRepository = transactionCommandRepository;
    }

    public async Task<TransactionResult> Handle(TransactionUpdateOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _transactionCommandRepository.UpdateTransaction(request.Id, request.Transactions);
        return new TransactionResult(result);
    }
}
