using Contable.Application.Services.Interfaces.Persistence.TaskRepository;
using Contable.Application.Transaction.Common;
using MediatR;

namespace Contable.Application.Task.Command.UpdateByOne;

public class TaskUpdateOneCommandHandler : IRequestHandler<TaskUpdateOneCommand, TaskResult>
{
    private readonly ITaskCommandRepository _taskCommandRepository;

    public TaskUpdateOneCommandHandler(ITaskCommandRepository taskCommandRepository)
    {
        _taskCommandRepository = taskCommandRepository;
    }

    public async Task<TaskResult> Handle(TaskUpdateOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _taskCommandRepository.UpdateTask(request.Id, request.Tasks);
        return new TaskResult(result);
    }
}
