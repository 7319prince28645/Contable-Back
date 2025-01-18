using FluentValidation;

namespace Contable.Application.Task.Command.Add;

public class TaskAddCommandValidator : AbstractValidator<TaskAddCommand>
{
    public TaskAddCommandValidator()
    {
        RuleFor(x => x.Tasks)
            .NotNull()
            .WithMessage("Task is required");
    }
}
