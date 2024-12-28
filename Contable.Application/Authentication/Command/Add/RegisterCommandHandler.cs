using Contable.Application.Authentication.Commom;
using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Domain.User;
using MediatR;

namespace Contable.Application.Authentication.Command.Add;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResultToken>
{
    private readonly IUserCommandRepository _userRepository;

    public RegisterCommandHandler(IUserCommandRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<AuthenticationResultToken> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
       
        var result = await _userRepository.AddAsync(request.Users);
        return new AuthenticationResultToken(result, "Token");

    }
}
