using FluentValidation;

namespace Contable.Application.Payment.Command.UpdateByOne;

public class PaymentUpdateOneCommandValidator : AbstractValidator<PaymentUpdateOneCommand>
{
    public PaymentUpdateOneCommandValidator()
    {
        RuleFor(x => x.Payments)
            .NotNull()
            .WithMessage("Payment is required");

     
    }
}
