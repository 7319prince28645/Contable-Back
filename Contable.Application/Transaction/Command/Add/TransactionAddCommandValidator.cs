using FluentValidation;

namespace Contable.Application.Transaction.Command.Add;

public class TransactionAddCommandValidator : AbstractValidator<TransactionAddCommand>
{
    public TransactionAddCommandValidator()
    {
        RuleFor(x => x.Transactions)
            .NotNull()
            .WithMessage("Transaction is required");
    }
}
