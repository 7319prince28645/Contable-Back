using FluentValidation;

namespace Contable.Application.Transaction.Command.Delete;

public class TransactionDeleteCommandValidator : AbstractValidator<TransactionDeleteCommand>
{
    public TransactionDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id is required");
    }
}

