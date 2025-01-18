using Contable.Application.Services.Interfaces.Persistence.TaskRepository;
using Contable.Domain.Task;

namespace Contable.Infrastructure.Persistence.Repository.TaskRepository;

public class TaskCommandRepository : ITaskCommandRepository
{
    private readonly ContextContable _context;

    public TaskCommandRepository(ContextContable context)
    {
        _context = context;
    }

    public async Task<Tasks> AddTask(Tasks task)
    {
        await _context.Tasks.AddAsync(task);
        await _context.SaveChangesAsync();
        return task;
    }

    public async Task<string> DeleteTask(Guid Id)
    {
        var result = await _context.Tasks.FindAsync(Id)
            ?? throw new Exception("Task not found");

        _context.Remove(result);
        await _context.SaveChangesAsync();
        return "Task deleted";
    }
    public async Task<Tasks> UpdateTask(Guid Id, Tasks task)
    {
        var result = await _context.Tasks.FindAsync(Id)
            ?? throw new Exception("Task not found");

        result.IsTerminated = task.IsTerminated;
        result.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();
        return result;

    }

    public async Task<Tasks> UpdateByOneTask(Guid Id, Tasks task)
    {
        var result = await _context.Tasks.FindAsync(Id)
            ?? throw new Exception("Task not found");

        result.IsTerminated = task.IsTerminated != result.IsTerminated ? task.IsTerminated : result.IsTerminated;
        result.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();
        return result;

    }

   
}
