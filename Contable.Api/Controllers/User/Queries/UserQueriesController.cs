using AutoMapper;
using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Contractx.Users.Queries;
using Contable.Domain.User;
using Contable.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contable.Api.Controllers.User.Queries;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Queries")]
public class UserQueriesController : ControllerBase
{
    private readonly IUserQueryRepository _userQueryRepository;
    private readonly ContextContable _context;
    private readonly IMapper _mapper;

    public UserQueriesController(IUserQueryRepository userQueryRepository, IMapper mapper, ContextContable context)
    {
        _userQueryRepository = userQueryRepository;
        _mapper = mapper;
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Users>> GetUsers()
    {
        var users = await _userQueryRepository.GetAllAsync();
        return users;

    }

    [HttpGet("{id}")]
    public async Task<UserDTO> GetUser(Guid id)
    {
        var user = await _userQueryRepository.GetByIdAsync(id);
        var userShow = _mapper.Map<UserDTO>(user);
        return userShow;
    }

    [HttpGet("{id}/payment")]
    public async Task<Users> GetUserPayment(Guid id)
    {
        var user = await _context.Users.Include(u => u.Payments).FirstOrDefaultAsync(u => u.Id == id);
        return user;


    }

    [HttpGet("email/{email}")]
    public async Task<UserDTO> GetUserByEmail(string email)
    {
        var user = await _userQueryRepository.GetByEmailAsync(email);
        return _mapper.Map<UserDTO>(user);
    }

}
