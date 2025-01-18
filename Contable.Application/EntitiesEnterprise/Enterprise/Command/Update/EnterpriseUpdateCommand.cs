using Contable.Application.EntitiesEnterprise.Enterprise.Common;
using Contable.Domain.Enterprise;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Enterprise.Command.Update;

public record EnterpriseUpdateCommand(Guid Id, Enterprises Enterprise) : IRequest<EnterpriseResult>;
