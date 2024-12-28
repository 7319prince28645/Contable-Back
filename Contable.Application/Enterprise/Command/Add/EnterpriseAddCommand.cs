using Contable.Application.Enterprise.Common;
using Contable.Domain.Enterprise;
using MediatR;

namespace Contable.Application.Enterprise.Command.Add;

public record EnterpriseAddCommand(Enterprises Enterprises) : IRequest<EnterpriseResult>;

