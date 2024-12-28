using FluentValidation;

namespace Contable.Application.Payment.Command.Update;

public class PaymentUpdateCommandValidator : AbstractValidator<PaymentUpdateCommand>
{
    public PaymentUpdateCommandValidator()
    {
        RuleFor(x => x.Payments)
            .NotNull()
            .WithMessage("Payment is required");
    
     
    }
}
