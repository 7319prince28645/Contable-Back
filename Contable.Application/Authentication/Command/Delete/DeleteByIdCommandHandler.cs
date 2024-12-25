using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using MediatR;

namespace Contable.Application.Authentication.Command.Delete;

public class DeleteByIdCommandHandler : IRequestHandler<DeleteByIdCommand, string>
{
    private readonly IUserCommandRepository _userRepository;

    public DeleteByIdCommandHandler(IUserCommandRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<string> Handle(DeleteByIdCommand request, CancellationToken cancellationToken)
    {
       await _userRepository.DeleteAsync(request.id);

        return "User deleted successfully";
    }
}
