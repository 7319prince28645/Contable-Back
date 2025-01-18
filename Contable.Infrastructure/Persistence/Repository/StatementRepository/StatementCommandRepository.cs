using Contable.Application.Services.Interfaces.Persistence.StatementRepository;
using Domain.Statement;

namespace Contable.Infrastructure.Persistence.Repository.StatementRepository;

public class StatementCommandRepository : IStatementCommandRepository
{
    private readonly ContextContable _context;

    public StatementCommandRepository(ContextContable context)
    {
        _context = context;
    }

    public async Task<Statements> AddStatement(Statements statement)
    {
        await _context.Statements.AddAsync(statement);
        await _context.SaveChangesAsync();

        return statement;

    }

    public async Task<string> DeleteStatement(Guid Id)
    {
        var result = await _context.Statements.FindAsync(Id)
            ?? throw new Exception("Statement not found");

        _context.Remove(result);
        await _context.SaveChangesAsync();
        return "Statement deleted";
    }

    public async Task<Statements> UpdateStatement(Guid Id, Statements statement)
    {
        var result = await _context.Statements.FindAsync(Id)
            ?? throw new Exception("Statement not found");

        result.DateStatement = DateTime.Now;

        await _context.SaveChangesAsync();
        return result;
    }

    public async Task<Statements> UpdateByOneStatement(Guid Id, Statements statement)
    {
        var result = await _context.Statements.FindAsync(Id)
            ?? throw new Exception("Statement not found");

        result.DateStatement = statement.DateStatement != result.DateStatement ? statement.DateStatement : result.DateStatement;

        await _context.SaveChangesAsync();
        return result;

    }
}
