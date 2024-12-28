using Contable.Application.Authentication.Commom;
using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Domain.User;
using MediatR;

namespace Contable.Application.Authentication.Command.Update;

public class UpdateByIdCommandHandler : IRequestHandler<UpdateByIdCommand, AuthenticationResult>
{
    private readonly IUserCommandRepository _userCommandRepository;
    public UpdateByIdCommandHandler(IUserCommandRepository userCommandRepository)
    {
        _userCommandRepository = userCommandRepository;
    }

    public async Task<AuthenticationResult> Handle(UpdateByIdCommand request, CancellationToken cancellationToken)
    {
       var result =  await _userCommandRepository.UpdateAsync(request.Id, request.Users);
        return new AuthenticationResult(result);
    }
}
