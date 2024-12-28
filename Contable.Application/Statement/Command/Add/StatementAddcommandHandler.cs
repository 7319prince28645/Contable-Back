using Contable.Application.Statement.Common;
using MediatR;

namespace Contable.Application.Statement.Command.Add;

public class StatementAddcommandHandler : IRequestHandler<StatementAddCommand, StatementResult>
{
    public async Task<StatementResult> Handle(StatementAddCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
