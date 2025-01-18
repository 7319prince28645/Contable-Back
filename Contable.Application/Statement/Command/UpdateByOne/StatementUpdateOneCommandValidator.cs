using FluentValidation;

namespace Contable.Application.Statement.Command.UpdateByOne;

public class StatementUpdateOneCommandValidator : AbstractValidator<StatementUpdateOneCommand>
{
    public StatementUpdateOneCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
