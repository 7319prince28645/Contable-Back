using Contable.Application.Services.Interfaces.Persistence.StatementRepository;
using Contable.Application.Statement.Common;
using Contable.Application.Transaction.Command.Update;
using MediatR;

namespace Contable.Application.Statement.Command.Update;

public class StatementUpdateCommandHandler : IRequestHandler<StatementUpdateCommand, StatementResult>
{
    private readonly IStatementCommandRepository _statementRepository;
    public StatementUpdateCommandHandler(IStatementCommandRepository statementRepository)
    {
        _statementRepository = statementRepository;
    }
    public async Task<StatementResult> Handle(StatementUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _statementRepository.UpdateStatement(request.Id, request.Statements);
        return new StatementResult(result);
    }
}

