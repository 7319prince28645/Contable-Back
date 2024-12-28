using AutoMapper;
using Contable.Application.Payment.Command.Add;
using Contable.Application.Payment.Command.Delete;
using Contable.Application.Payment.Command.Update;
using Contable.Application.Payment.Command.UpdateByOne;
using Contable.Contractx.Payment.Command;
using Domain.Payment;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.Payment.Commands;


[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "Commands")]
public class PaymentCommandController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public PaymentCommandController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> AddPayment(AddPayment command)
    {
        var result = _mapper.Map<Payments>(command);
        var resultCommand = new PaymentAddCommand(result);
        var resultCommandPayment = await _mediator.Send(resultCommand);
        return Ok(resultCommandPayment);
    }

    [HttpPut("{Id}")]
    public async Task<IActionResult> UpdatePayment(Guid Id, AddPayment command)
    {
        var result = _mapper.Map<Payments>(command);
        var resultCommand = new PaymentUpdateCommand(Id, result);
        var resultCommandResult = await _mediator.Send(resultCommand);
        return Ok(resultCommandResult);
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> DeletePayment(Guid Id)
    {
        var command = new PaymentDeleteCommand(Id);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPatch("{Id}")]
    public async Task<IActionResult> UpdatePaymentByOne(Guid Id, AddPayment command)
    {
        var result = _mapper.Map<Payments>(command);
        var resultCommand = new PaymentUpdateOneCommand(Id, result);
        var resultCommandResult = await _mediator.Send(resultCommand);

        return Ok(resultCommandResult);
    }


}
