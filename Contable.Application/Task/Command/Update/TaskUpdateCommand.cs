using Contable.Application.Transaction.Common;
using Contable.Domain.Task;
using MediatR;

namespace Contable.Application.Task.Command.Update;

public record TaskUpdateCommand(Guid Id, Tasks Tasks) : IRequest<TaskResult>;
