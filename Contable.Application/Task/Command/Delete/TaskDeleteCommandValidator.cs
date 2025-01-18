using Contable.Application.Transaction.Command.Delete;
using FluentValidation;

namespace Contable.Application.Task.Command.Delete;

public class TaskDeleteCommandValidator : AbstractValidator<TaskDeleteCommand>
{
    public TaskDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id is required");
    }
}
