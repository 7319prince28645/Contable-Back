using FluentValidation;

namespace Contable.Application.Transaction.Command.Update;

public class TransactionUpdateCommandValidator : AbstractValidator<TransactionUpdateCommand>
{
    public TransactionUpdateCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id is required");


        RuleFor(x => x.Transactions)
            .NotNull()
            .WithMessage("Transaction is required");
    }
}
