using AutoMapper;
using Contable.Application.Transaction.Command.Add;
using Contable.Application.Transaction.Command.Delete;
using Contable.Application.Transaction.Command.Update;
using Contable.Application.Transaction.Command.UpdateByOne;
using Contable.Contractx.Transaction.Command;
using Domain.Transaction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.Transaction.Command;

[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "Commands")]
public class TransactionCommandController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;
    public TransactionCommandController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    [HttpPost]
    public async Task<IActionResult> CreateTransaction(TransactionAdd command)
    {
        var result = _mapper.Map<Transactions>(command);
        var resultCommand = new TransactionAddCommand(result);
        var resultCommandTransaction = await _mediator.Send(resultCommand);
        return Ok(resultCommandTransaction);
    }
    [HttpPut("{Id}")]
    public async Task<IActionResult> UpdateTransaction(Guid Id, TransactionAdd command)
    {
        var result = _mapper.Map<Transactions>(command);
        var resultCommand = new TransactionUpdateCommand(Id, result);
        var resultCommandResult = await _mediator.Send(resultCommand);
        return Ok(resultCommandResult);
    }
    [HttpDelete("{Id}")]
    public async Task<IActionResult> DeleteTransaction(Guid Id)
    {
        var command = new TransactionDeleteCommand(Id);
        var result = await _mediator.Send(command);
        return Ok(result);
    }
    [HttpPatch("{Id}")]
    public async Task<IActionResult> UpdateTransactionByOne(Guid Id, TransactionAdd command)
    {
        var result = _mapper.Map<Transactions>(command);
        var resultCommand = new TransactionUpdateOneCommand(Id, result);
        var resultCommandResult = await _mediator.Send(resultCommand);
        return Ok(resultCommandResult);
    }
}
