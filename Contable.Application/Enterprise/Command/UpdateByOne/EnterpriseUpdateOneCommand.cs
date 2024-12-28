using Contable.Application.Enterprise.Common;
using Contable.Domain.Enterprise;
using MediatR;

namespace Contable.Application.Enterprise.Command.UpdateByOne;

public record EnterpriseUpdateOneCommand(Guid Id, Enterprises Enterprises) : IRequest<EnterpriseResult>;
