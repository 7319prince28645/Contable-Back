using Contable.Application.Enterprise.Commands.Detele;
using FluentValidation;

namespace Contable.Application.Enterprise.Command.Detele;

public class EnterpriseDeleteCommandValidator : AbstractValidator<EnterpriseDeleteCommand>
{
    public EnterpriseDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
