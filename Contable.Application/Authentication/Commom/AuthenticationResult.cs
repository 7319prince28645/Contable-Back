using Contable.Domain.User;

namespace Contable.Application.Authentication.Commom;

public record AuthenticationResult(Users Users, string Token);
