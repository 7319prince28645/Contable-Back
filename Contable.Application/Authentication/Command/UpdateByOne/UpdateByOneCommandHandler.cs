using Contable.Application.Authentication.Commom;
using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Domain.User;
using MediatR;

namespace Contable.Application.Authentication.Command.UpdateByOne;

public class UpdateByOneCommandHandler : IRequestHandler<UpdateByOneCommand, AuthenticationResult>
{
    private readonly IUserCommandRepository _userCommandRepository;

    public UpdateByOneCommandHandler(IUserCommandRepository userCommandRepository)
    {
        _userCommandRepository = userCommandRepository;
    }

    public async Task<AuthenticationResult> Handle(UpdateByOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _userCommandRepository.UpdateAsyncByOne(request.Id, request.Users);
        return new AuthenticationResult(result);

    }
}
