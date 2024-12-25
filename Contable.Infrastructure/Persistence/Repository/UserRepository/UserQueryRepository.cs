using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Contable.Infrastructure.Persistence.Repository.UserRepository;

public class UserQueryRepository : IUserQueryRepository
{
    private readonly ContextContable _context;

    public UserQueryRepository(ContextContable context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Users>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public Task<Users> GetByEmailAsync(string email)
    {
        var user = _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        return user;
    }

    public Task<Users> GetByIdAsync(Guid id)
    {
        var user = _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        return user;
    }
}
