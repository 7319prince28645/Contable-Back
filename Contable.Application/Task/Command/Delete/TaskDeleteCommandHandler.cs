using Contable.Application.Services.Interfaces.Persistence.TaskRepository;
using Contable.Application.Transaction.Command.Delete;
using MediatR;

namespace Contable.Application.Task.Command.Delete;

public class TaskDeleteCommandHandler : IRequestHandler<TaskDeleteCommand, string>
{
    private readonly ITaskCommandRepository _taskCommandRepository;

    public TaskDeleteCommandHandler(ITaskCommandRepository taskCommandRepository)
    {
        _taskCommandRepository = taskCommandRepository;
    }

    public async Task<string> Handle(TaskDeleteCommand request, CancellationToken cancellationToken)
    {
        return await _taskCommandRepository.DeleteTask(request.Id);
        
    }
}
