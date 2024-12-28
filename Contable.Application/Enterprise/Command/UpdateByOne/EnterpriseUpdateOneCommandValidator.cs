using FluentValidation;

namespace Contable.Application.Enterprise.Command.UpdateByOne;

public class EnterpriseUpdateOneCommandValidator : AbstractValidator<EnterpriseUpdateOneCommand>
{
    public EnterpriseUpdateOneCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Enterprises).NotNull();
    }
}
