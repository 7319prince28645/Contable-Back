using Contable.Application.Services.Interfaces.Persistence.StatementRepository;
using Contable.Application.Statement.Common;
using MediatR;

namespace Contable.Application.Statement.Command.UpdateByOne;

public class StatementUpdateOneCommandHandler : IRequestHandler<StatementUpdateOneCommand, StatementResult>
{
    private readonly IStatementCommandRepository _statementRepository;

    public StatementUpdateOneCommandHandler(IStatementCommandRepository statementRepository)
    {
        _statementRepository = statementRepository;
    }

    public async Task<StatementResult> Handle(StatementUpdateOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _statementRepository.UpdateByOneStatement(request.Id, request.Statements);
        return new StatementResult(result);
    }

}
