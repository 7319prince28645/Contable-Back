using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Domain.User;
using MediatR;

namespace Contable.Application.Authentication.Command.Update;

public class UpdateByIdCommandHandler : IRequestHandler<UpdateByIdCommand, Users>
{
    private readonly IUserCommandRepository _userCommandRepository;
    public UpdateByIdCommandHandler(IUserCommandRepository userCommandRepository)
    {
        _userCommandRepository = userCommandRepository;
    }

    public async Task<Users> Handle(UpdateByIdCommand request, CancellationToken cancellationToken)
    {
        await _userCommandRepository.UpdateAsync(request.Id, request.Users);
        return request.Users;
    }
}
