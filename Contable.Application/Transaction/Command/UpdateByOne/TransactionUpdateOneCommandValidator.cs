using FluentValidation;

namespace Contable.Application.Transaction.Command.UpdateByOne;

public class TransactionUpdateOneCommandValidator : AbstractValidator<TransactionUpdateOneCommand>
{
    public TransactionUpdateOneCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id is required");

        RuleFor(x => x.Transactions)
            .NotNull()
            .WithMessage("Transaction is required");
    }
}
