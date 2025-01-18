using FluentValidation;

namespace Contable.Application.Statement.Command.Delete;

public class StatementDeleteCommandValidator : AbstractValidator<StatementDeleteCommand>
{
    public StatementDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
