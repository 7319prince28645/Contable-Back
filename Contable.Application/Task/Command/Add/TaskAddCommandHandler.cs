using Contable.Application.Services.Interfaces.Persistence.TaskRepository;
using Contable.Application.Transaction.Common;
using MediatR;

namespace Contable.Application.Task.Command.Add;

public class TaskAddCommandHandler : IRequestHandler<TaskAddCommand, TaskResult>
{
    private readonly ITaskCommandRepository _taskCommandRepository;

    public TaskAddCommandHandler(ITaskCommandRepository taskCommandRepository)
    {
        _taskCommandRepository = taskCommandRepository;
    }

    public async Task<TaskResult> Handle(TaskAddCommand request, CancellationToken cancellationToken)
    {
        var result = await _taskCommandRepository.AddTask(request.Tasks);
        return new TaskResult(result);
    }
}
