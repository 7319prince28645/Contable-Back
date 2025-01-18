using Contable.Application.EntitiesEnterprise.Enterprise.Common;
using Contable.Domain.Enterprise;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Enterprise.Command.UpdateByOne;

public record EnterpriseUpdateOneCommand(Guid Id, Enterprises Enterprises) : IRequest<EnterpriseResult>;
