using FluentValidation;

namespace Contable.Application.Task.Command.UpdateByOne;

public class TaskUpdateOneCommandValidator : AbstractValidator<TaskUpdateOneCommand>
{
    public TaskUpdateOneCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id is required");

        RuleFor(x => x.Tasks)
            .NotNull()
            .WithMessage("Task is required");
    }
}
