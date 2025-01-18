using FluentValidation;

namespace Contable.Application.EntitiesEnterprise.Enterprise.Command.Detele;

public class EnterpriseDeleteCommandValidator : AbstractValidator<EnterpriseDeleteCommand>
{
    public EnterpriseDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
