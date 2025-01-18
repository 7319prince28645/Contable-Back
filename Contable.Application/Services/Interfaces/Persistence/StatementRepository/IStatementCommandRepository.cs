using Domain.Statement;

namespace Contable.Application.Services.Interfaces.Persistence.StatementRepository;

public interface IStatementCommandRepository
{
    Task<Statements> AddStatement(Statements statement);
    Task<string> DeleteStatement(Guid Id);
    Task<Statements> UpdateStatement(Guid Id, Statements statement);
    Task<Statements> UpdateByOneStatement(Guid Id, Statements statement);
}
