using Domain.Transaction;

namespace Contable.Application.Services.Interfaces.Persistence.TransactionRepository;

public interface ITransactionCommandRepository 
{
    Task<Transactions> CreateTransaction(Transactions transactions);
    Task<string> DeleteTransaction(Guid Id);
    Task<Transactions> UpdateTransaction(Guid Id, Transactions transactions);
    Task<Transactions> UpdateByOneTransaction(Guid Id, Transactions transactions);

}
