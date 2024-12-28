using Contable.Application.Statement.Common;
using Domain.Statement;
using MediatR;

namespace Contable.Application.Statement.Command.Add;

public record StatementAddCommand(Statements Statements) : IRequest<StatementResult>;
