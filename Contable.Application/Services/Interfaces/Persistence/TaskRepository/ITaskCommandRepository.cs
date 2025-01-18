using Contable.Domain.Task;

namespace Contable.Application.Services.Interfaces.Persistence.TaskRepository;

public interface ITaskCommandRepository
{
    Task<Tasks> AddTask(Tasks task);
    Task<string> DeleteTask(Guid Id);
    Task<Tasks> UpdateByOneTask(Guid Id, Tasks task);
    Task<Tasks> UpdateTask(Guid Id, Tasks task);
}
