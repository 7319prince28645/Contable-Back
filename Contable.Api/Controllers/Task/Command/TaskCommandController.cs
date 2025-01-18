using AutoMapper;
using Contable.Application.Task.Command.Add;
using Contable.Application.Task.Command.Delete;
using Contable.Application.Task.Command.Update;
using Contable.Application.Task.Command.UpdateByOne;
using Contable.Contractx.Task.Command;
using Contable.Domain.Task;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.Task.Command;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Commands")]
public class TaskCommandController : ControllerBase
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public TaskCommandController(IMapper mapper, ISender sender)
    {
        _mapper = mapper;
        _sender = sender;
    }

    [HttpPost]
    public async Task<IActionResult> AddTask(TaskAdd command)
    {
        var result = _mapper.Map<Tasks>(command);
        var resultCommand = new TaskAddCommand(result);
        var resultCommandResult = await _sender.Send(resultCommand);
        return Ok(resultCommandResult);
    }

    [HttpPut("{Id}")]
    public async Task<IActionResult> UpdateTask(Guid Id, TaskAdd command)
    {
        var result = _mapper.Map<Tasks>(command);
        var resultCommand = new TaskUpdateCommand(Id, result);
        var resultCommandResult = await _sender.Send(resultCommand);
        return Ok(resultCommandResult);
    }

    [HttpPatch("{Id}")]
    public async Task<IActionResult> UpdateTaskByOne(Guid Id, TaskAdd command)
    {
        var result = _mapper.Map<Tasks>(command);
        var resultCommand = new TaskUpdateOneCommand(Id, result);
        var resultCommandResult = await _sender.Send(resultCommand);
        return Ok(resultCommandResult);
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> DeleteTask(Guid Id)
    {
        var command = new TaskDeleteCommand(Id);
        var result = await _sender.Send(command);
        return Ok(result);
    }
}
