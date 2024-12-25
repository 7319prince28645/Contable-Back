using Contable.Application.Authentication.Commom;
using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Domain.User;
using MediatR;

namespace Contable.Application.Authentication.Command.Add;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResult>
{
    private readonly IUserCommandRepository _userRepository;

    public RegisterCommandHandler(IUserCommandRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<AuthenticationResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
       
        await _userRepository.AddAsync(request.Users);
        return new AuthenticationResult(request.Users, "Token");

    }
}
