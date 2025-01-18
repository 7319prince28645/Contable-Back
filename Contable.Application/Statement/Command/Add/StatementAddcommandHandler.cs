using Contable.Application.Services.Interfaces.Persistence.StatementRepository;
using Contable.Application.Statement.Common;
using MediatR;

namespace Contable.Application.Statement.Command.Add;

public class StatementAddcommandHandler : IRequestHandler<StatementAddCommand, StatementResult>
{
    private readonly IStatementCommandRepository _statementCommandRepository;

    public StatementAddcommandHandler(IStatementCommandRepository statementCommandRepository)
    {
        _statementCommandRepository = statementCommandRepository;
    }

    public async Task<StatementResult> Handle(StatementAddCommand request, CancellationToken cancellationToken)
    {
        var result = await _statementCommandRepository.AddStatement(request.Statements);
        return new StatementResult(result);
    }
}
