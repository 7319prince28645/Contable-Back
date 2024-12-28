using AutoMapper;
using Contable.Application.Authentication.Command;
using Contable.Application.Authentication.Command.Delete;
using Contable.Application.Authentication.Command.Update;
using Contable.Application.Authentication.Command.UpdateByOne;
using Contable.Contractx.Users;
using Contable.Contractx.Users.Commands;
using Contable.Domain.User;
using MediatR;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.User.Commands;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Commands")] 
public class UserCommandController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public UserCommandController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> AddUser(CreateDTO createDTO)
    {
        var command = _mapper.Map<RegisterCommand>(createDTO);
        var result = await _mediator.Send(command);
        var response = _mapper.Map<AuthenticationResponse>(result);

        return CreatedAtAction(nameof(AddUser), response);
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> DeleteUser(Guid id)
    {
        var command = _mapper.Map<DeleteByIdCommand>(id);
        var result = await _mediator.Send(command);

        return Ok(result);
    }

    [HttpPut("{id}")]

    public async Task<IActionResult> UpdateUser(Guid id, UpdateDTO? updateDTO)
    {
        
        var users = _mapper.Map<Users>(updateDTO);
        var command = new UpdateByIdCommand(id, users);
        var result = await _mediator.Send(command);

        return Ok(result);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateUserPatch(Guid id, UpdateDTO updateDTO)
    {
        var users = _mapper.Map<Users>(updateDTO);
        var command = new UpdateByOneCommand(id, users);
        var result = await _mediator.Send(command);

        return Ok(result);
    }
}
