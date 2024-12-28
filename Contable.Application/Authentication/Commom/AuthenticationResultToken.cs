using Contable.Domain.User;

namespace Contable.Application.Authentication.Commom;

public record AuthenticationResultToken(Users Users, string Token);