using Contable.Application.Transaction.Common;
using Contable.Domain.Task;
using MediatR;

namespace Contable.Application.Task.Command.UpdateByOne;

public record TaskUpdateOneCommand(Guid Id, Tasks Tasks) : IRequest<TaskResult>;
