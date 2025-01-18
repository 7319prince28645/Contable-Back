using FluentValidation;

namespace Contable.Application.Task.Command.Update;

public class TaskUpdateCommandValidator : AbstractValidator<TaskUpdateCommand>
{
    public TaskUpdateCommandValidator()
    {

        RuleFor(x=> x.Id)
            .NotNull()
            .WithMessage("Id is required");

        RuleFor(x => x.Tasks)
            .NotNull()
            .WithMessage("Task is required");
    }
}
