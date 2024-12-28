using FluentValidation;

namespace Contable.Application.Payment.Command.Add;

public class PaymentAddCommandValidator : AbstractValidator<PaymentAddCommand>
{
    public PaymentAddCommandValidator()
    {
        RuleFor(x => x.Payments)
            .NotNull()
            .WithMessage("Payments cannot be null");
        RuleFor(x => x.Payments)
            .NotEmpty()
            .WithMessage("Payments cannot be empty");
    
    }
}
