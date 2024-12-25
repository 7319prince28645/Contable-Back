using Contable.Application.Authentication.Commom;
using Contable.Domain.User;
using MediatR;

namespace Contable.Application.Authentication.Command;

public record RegisterCommand(Users Users) : IRequest<AuthenticationResult>;