using Contable.Domain.User;
using MediatR;

namespace Contable.Application.Authentication.Command.Update;

public record UpdateByIdCommand(Guid Id, Users Users) : IRequest<Users>;
