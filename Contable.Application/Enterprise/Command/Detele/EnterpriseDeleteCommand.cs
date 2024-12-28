using MediatR;

namespace Contable.Application.Enterprise.Commands.Detele;

public record EnterpriseDeleteCommand(Guid Id) : IRequest<string>;
