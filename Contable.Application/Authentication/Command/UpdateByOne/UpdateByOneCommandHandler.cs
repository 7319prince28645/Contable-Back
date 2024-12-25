using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Domain.User;
using MediatR;

namespace Contable.Application.Authentication.Command.UpdateByOne;

public class UpdateByOneCommandHandler : IRequestHandler<UpdateByOneCommand, Users>
{
    private readonly IUserCommandRepository _userCommandRepository;

    public UpdateByOneCommandHandler(IUserCommandRepository userCommandRepository)
    {
        _userCommandRepository = userCommandRepository;
    }

    public async Task<Users> Handle(UpdateByOneCommand request, CancellationToken cancellationToken)
    {
        await _userCommandRepository.UpdateAsyncByOne(request.Id, request.Users);
        return request.Users;

    }
}
