using Azure.Core;
using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Contable.Infrastructure.Persistence.Repository.UserRepository;

public class UserCommandRepository : IUserCommandRepository
{
    private readonly ContextContable _context;

    public UserCommandRepository(ContextContable context)
    {
        _context = context;
    }

    public async Task<Users> AddAsync(Users user)
    {
        var data = new Users
        {
            Email = user.Email,
            Password = user.Password,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Salary = user.Salary,
            Planilla = user.Planilla,
            DateBeginning = user.DateBeginning
        };
        if (user.Planilla)
        {
            data.DatePlanilla = user.DatePlanilla;
        }
        _context.Users.AddAsync(data);
        await _context.SaveChangesAsync();
        return data;
    }

    public async Task<Users> DeleteAsync(Guid id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null)
        {
            throw new Exception("User not found");
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<Users> UpdateAsync(Guid id, Users users)
    {
        var userToUpdate = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (userToUpdate == null)
        {
            throw new Exception("User not found");
        }

        userToUpdate.Email = users.Email;
        userToUpdate.Password = users.Password;
        userToUpdate.FirstName = users.FirstName;
        userToUpdate.LastName = users.LastName;
        userToUpdate.Salary = users.Salary;
        userToUpdate.Planilla = users.Planilla;
        userToUpdate.DateBeginning = users.DateBeginning;
        userToUpdate.DatePlanilla = users.DatePlanilla;


        _context.Users.Update(userToUpdate);
        await _context.SaveChangesAsync();
        return userToUpdate;
    }

    public async Task<Users> UpdateAsyncByOne(Guid id, Users users)
    {
        var userToUpdate = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

        if (userToUpdate == null)
        {
            throw new Exception("User not found");
        }
        if (!string.IsNullOrEmpty(users.Email))
            userToUpdate.Email = users.Email;

        if (!string.IsNullOrEmpty(users.Password))
            userToUpdate.Password = users.Password;

        if (!string.IsNullOrEmpty(users.FirstName))
            userToUpdate.FirstName = users.FirstName;

        if (!string.IsNullOrEmpty(users.LastName))
            userToUpdate.LastName = users.LastName;

        if (users.Salary != 0)
            userToUpdate.Salary = users.Salary;

        if (users.Planilla != null)
            userToUpdate.Planilla = users.Planilla;

        if (users.DateBeginning != null)
            userToUpdate.DateBeginning = users.DateBeginning;

        if (users.DatePlanilla != null)
            userToUpdate.DatePlanilla = users.DatePlanilla;

        _context.Users.Update(userToUpdate);

        await _context.SaveChangesAsync();

        return userToUpdate;

    }
}
