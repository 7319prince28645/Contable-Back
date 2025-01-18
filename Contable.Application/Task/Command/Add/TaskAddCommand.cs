using Contable.Application.Transaction.Common;
using Contable.Domain.Task;
using MediatR;

namespace Contable.Application.Task.Command.Add;

public record TaskAddCommand(Tasks Tasks) : IRequest<TaskResult>;
