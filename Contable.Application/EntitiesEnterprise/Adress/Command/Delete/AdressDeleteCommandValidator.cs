using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.Delete;

public class AdressDeleteCommandValidator : AbstractValidator<AdressDeleteCommand>
{
    public AdressDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.");
    }
}
