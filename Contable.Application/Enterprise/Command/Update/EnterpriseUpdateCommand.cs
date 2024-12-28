using Contable.Application.Enterprise.Common;
using Contable.Domain.Enterprise;
using MediatR;

namespace Contable.Application.Enterprise.Command.Update;

public record EnterpriseUpdateCommand(Guid Id, Enterprises Enterprise) : IRequest<EnterpriseResult>;
