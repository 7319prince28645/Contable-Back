using Contable.Domain.User;
using MediatR;

namespace Contable.Application.Authentication.Command.UpdateByOne;

public record UpdateByOneCommand(Guid Id, Users Users) : IRequest<Users>;
