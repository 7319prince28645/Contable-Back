using Contable.Domain.User;

namespace Contable.Application.Services.Interfaces.Persistence.UserRepository;

public interface IUserQueryRepository
{
    Task<IEnumerable<Users>> GetAllAsync();
    Task<Users> GetByIdAsync(Guid id);
    Task<Users> GetByEmailAsync(string email);
}
