using FluentValidation;

namespace Contable.Application.Payment.Command.Delete;

public class PaymentDeleteCommandValidator : AbstractValidator<PaymentDeleteCommand>
{
    public PaymentDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
