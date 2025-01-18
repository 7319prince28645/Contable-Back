using AutoMapper;
using Contable.Application.Statement.Command.Add;
using Contable.Application.Statement.Command.Delete;
using Contable.Application.Statement.Command.UpdateByOne;
using Contable.Application.Transaction.Command.Update;
using Contable.Contractx.Statement.Command;
using Domain.Statement;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.Statement.Command;

[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "Commands")]
public class StatementCommandController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;
    public StatementCommandController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    [HttpPost]
    public async Task<IActionResult> AddStatement(AddStatement command)
    {
        var result = _mapper.Map<Statements>(command);
        var resultCommand = new StatementAddCommand(result);
        var resultCommandStatement = await _mediator.Send(resultCommand);
        return Ok(resultCommandStatement);
    }
    [HttpPut("{Id}")]
    public async Task<IActionResult> UpdateStatement(Guid Id, AddStatement command)
    {
        var result = _mapper.Map<Statements>(command);
        var resultCommand = new StatementUpdateCommand(Id, result);
        var resultCommandResult = await _mediator.Send(resultCommand);
        return Ok(resultCommandResult);
    }
    [HttpDelete("{Id}")]
    public async Task<IActionResult> DeleteStatement(Guid Id)
    {
        var command = new StatementDeleteCommand(Id);
        var result = await _mediator.Send(command);
        return Ok(result);
    }
    [HttpPatch("{Id}")]
    public async Task<IActionResult> UpdateStatementByOne(Guid Id, AddStatement command)
    {
        var result = _mapper.Map<Statements>(command);
        var resultCommand = new StatementUpdateOneCommand(Id, result);
        var resultCommandResult = await _mediator.Send(resultCommand);
        return Ok(resultCommandResult);
    }
}
