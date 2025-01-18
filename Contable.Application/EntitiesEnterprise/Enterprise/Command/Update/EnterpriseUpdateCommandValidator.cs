using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Enterprise.Command.Update;

public class EnterpriseUpdateCommandValidator : AbstractValidator<EnterpriseUpdateCommand>
{
    public EnterpriseUpdateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Enterprise).NotNull();
    }
}
