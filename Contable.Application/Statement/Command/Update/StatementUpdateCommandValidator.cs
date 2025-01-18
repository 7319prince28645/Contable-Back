using Contable.Application.Transaction.Command.Update;
using FluentValidation;

namespace Contable.Application.Statement.Command.Update;

public class StatementUpdateCommandValidator : AbstractValidator<StatementUpdateCommand>
{
    public StatementUpdateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Statements).NotEmpty();
    }
}
