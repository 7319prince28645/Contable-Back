using Contable.Application.Services.Interfaces.Persistence.TaskRepository;
using Contable.Application.Transaction.Common;
using MediatR;

namespace Contable.Application.Task.Command.Update;

public class TaskUpdateCommandHandler : IRequestHandler<TaskUpdateCommand, TaskResult>
{
    private readonly ITaskCommandRepository _taskCommandRepository;

    public TaskUpdateCommandHandler(ITaskCommandRepository taskCommandRepository)
    {
        _taskCommandRepository = taskCommandRepository;
    }

    public async Task<TaskResult> Handle(TaskUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _taskCommandRepository.UpdateTask(request.Id, request.Tasks);
        return new TaskResult(result);
    }
}
