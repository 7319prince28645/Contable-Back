using AutoMapper;
using Contable.Application.Services.Interfaces.Persistence.UserRepository;
using Contable.Contractx.Users.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.User.Queries;

[Route("api/[controller]")]
[ApiController]
public class UserQueriesController : ControllerBase
{
    private readonly IUserQueryRepository _userQueryRepository;
    private readonly IMapper _mapper;

    public UserQueriesController(IUserQueryRepository userQueryRepository, IMapper mapper)
    {
        _userQueryRepository = userQueryRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<UserDTO>> GetUsers()
    {
        var users = await _userQueryRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<UserDTO>>(users);

    }

    [HttpGet("{id}")]
    public async Task<UserDTO> GetUser(Guid id)
    {
        var user = await _userQueryRepository.GetByIdAsync(id);
        return _mapper.Map<UserDTO>(user);
    }

    [HttpGet("email/{email}")]
    public async Task<UserDTO> GetUserByEmail(string email)
    {
        var user = await _userQueryRepository.GetByEmailAsync(email);
        return _mapper.Map<UserDTO>(user);
    }

}
