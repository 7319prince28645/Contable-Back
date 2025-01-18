using FluentValidation;

namespace Contable.Application.Statement.Command.Add;

public class StatementAddCommandValidator : AbstractValidator<StatementAddCommand>
{
    public StatementAddCommandValidator()
    {
        RuleFor(x => x.Statements)
            .NotNull()
            .WithMessage("Statement is required");
    }
}
