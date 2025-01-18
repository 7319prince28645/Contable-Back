using Contable.Application.Services.Interfaces.Persistence.TransactionRepository;
using MediatR;

namespace Contable.Application.Transaction.Command.Delete;

public class TransactionDeleteCommandHandler : IRequestHandler<TransactionDeleteCommand, string>
{
    private readonly ITransactionCommandRepository _transactionCommandRepository;

    public TransactionDeleteCommandHandler(ITransactionCommandRepository transactionCommandRepository)
    {
        _transactionCommandRepository = transactionCommandRepository;
    }

    public async Task<string> Handle(TransactionDeleteCommand request, CancellationToken cancellationToken)
    {
        return await _transactionCommandRepository.DeleteTransaction(request.Id);
    }
}
