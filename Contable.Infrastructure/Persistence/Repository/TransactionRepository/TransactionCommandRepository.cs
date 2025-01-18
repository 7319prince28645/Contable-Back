using Contable.Application.Services.Interfaces.Persistence.TransactionRepository;
using Domain.Transaction;

namespace Contable.Infrastructure.Persistence.Repository.TransactionRepository;

public class TransactionCommandRepository : ITransactionCommandRepository
{
    private readonly ContextContable _context;

    public TransactionCommandRepository(ContextContable context)
    {
        _context = context;
    }

    public async Task<Transactions> CreateTransaction(Transactions transactions)
    {
        await _context.Transactions.AddAsync(transactions);
        await _context.SaveChangesAsync();
        return transactions;

    }

    public async Task<string> DeleteTransaction(Guid Id)
    {
        var result = await _context.Transactions.FindAsync(Id)
            ?? throw new Exception("Transaction not found");

        _context.Remove(result);
        await _context.SaveChangesAsync();

        return "Transaction deleted";
    }


    public async Task<Transactions> UpdateTransaction(Guid Id, Transactions transactions)
    {
        var result = await _context.Transactions.FindAsync(Id)
            ?? throw new Exception("Transaction not found");

        result.Description = transactions.Description;
        result.ReemSales = transactions.ReemSales;
        result.IsTerminated = transactions.IsTerminated;
        result.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();
        return result;

    }


    public async Task<Transactions> UpdateByOneTransaction(Guid Id, Transactions transactions)
    {
        var result = await _context.Transactions.FindAsync(Id)
            ?? throw new Exception("Transaction not found");

        result.Description = transactions.Description ?? result.Description;
        result.ReemSales = transactions.ReemSales != result.ReemSales ? transactions.ReemSales : result.ReemSales;
        result.IsTerminated = transactions.IsTerminated != result.IsTerminated ? transactions.IsTerminated : result.IsTerminated;
        result.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();
        return result;
    }
}
