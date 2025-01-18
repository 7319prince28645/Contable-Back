using Contable.Application.Statement.Common;
using Domain.Statement;
using MediatR;

namespace Contable.Application.Transaction.Command.Update;

public record StatementUpdateCommand(Guid Id, Statements Statements) : IRequest<StatementResult>;
