using FluentValidation;

namespace Contable.Application.Authentication.Command.Delete;

public class DeleteByIdCommandValidator : AbstractValidator<DeleteByIdCommand>
{
    public DeleteByIdCommandValidator()
    {
        RuleFor(x => x.id)
            .NotEmpty().WithMessage("Id is required por favoooor");
    }
}
