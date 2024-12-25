using FluentValidation;

namespace Contable.Application.Authentication.Command.Add;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(x => x.Users.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Email is not valid");
        RuleFor(x => x.Users.Password)
            .NotEmpty().WithMessage("Password is required")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters");
        RuleFor(x => x.Users.FirstName)
            .NotEmpty().WithMessage("FirstName is required");
        RuleFor(x => x.Users.LastName)
            .NotEmpty().WithMessage("LastName is required");
        RuleFor(x => x.Users.Salary)
            .NotEmpty().WithMessage("Salary is required");
        RuleFor(x => x.Users.DateBeginning)
            .NotEmpty().WithMessage("DateBeginning is required");
        RuleFor(x => x.Users.Planilla)
            .NotEmpty().WithMessage("Planilla is required");
    }
}
