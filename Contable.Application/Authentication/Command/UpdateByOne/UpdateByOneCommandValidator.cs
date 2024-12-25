using FluentValidation;

namespace Contable.Application.Authentication.Command.UpdateByOne;

public class UpdateByOneCommandValidator : AbstractValidator<UpdateByOneCommand>
{
    public UpdateByOneCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
