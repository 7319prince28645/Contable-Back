using Contable.Application.EntitiesEnterprise.Enterprise.Common;
using Contable.Domain.Enterprise;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Enterprise.Command.Add;

public record EnterpriseAddCommand(Enterprises Enterprises) : IRequest<EnterpriseResult>;

