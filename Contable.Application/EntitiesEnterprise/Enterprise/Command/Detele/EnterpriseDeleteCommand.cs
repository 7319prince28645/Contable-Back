using MediatR;

namespace Contable.Application.EntitiesEnterprise.Enterprise.Command.Detele;

public record EnterpriseDeleteCommand(Guid Id) : IRequest<string>;
