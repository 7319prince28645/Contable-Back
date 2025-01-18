using Contable.Application.Services.Interfaces.Persistence.StatementRepository;
using MediatR;

namespace Contable.Application.Statement.Command.Delete;

public class StatementDeleteCommandHandler : IRequestHandler<StatementDeleteCommand, string>
{
    private readonly IStatementCommandRepository _statementRepository;

    public StatementDeleteCommandHandler(IStatementCommandRepository statementRepository)
    {
        _statementRepository = statementRepository;
    }

    public async Task<string> Handle(StatementDeleteCommand request, CancellationToken cancellationToken)
    {
        return await _statementRepository.DeleteStatement(request.Id);
    }
}
