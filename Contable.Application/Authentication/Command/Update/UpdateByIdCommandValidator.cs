using FluentValidation;

namespace Contable.Application.Authentication.Command.Update;

public class UpdateByIdCommandValidator : AbstractValidator<UpdateByIdCommand>
{
    public UpdateByIdCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
