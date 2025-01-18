using Contable.Application.Statement.Common;
using Domain.Statement;
using MediatR;

namespace Contable.Application.Statement.Command.UpdateByOne;

public record StatementUpdateOneCommand(Guid Id, Statements Statements) : IRequest<StatementResult>;
