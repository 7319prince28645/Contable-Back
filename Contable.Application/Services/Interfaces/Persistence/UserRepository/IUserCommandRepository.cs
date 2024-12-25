using Contable.Domain.User;

namespace Contable.Application.Services.Interfaces.Persistence.UserRepository;

public interface IUserCommandRepository
{
    Task<Users> AddAsync(Users user);
    Task<Users> UpdateAsync(Guid id, Users users);
    Task<Users> DeleteAsync(Guid id);
    Task<Users> UpdateAsyncByOne(Guid id, Users users);
}
