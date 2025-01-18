using AutoMapper;
using Contable.Application.EntitiesEnterprise.Regimes.Command.Add;
using Contable.Application.EntitiesEnterprise.Regimes.Command.Delete;
using Contable.Application.EntitiesEnterprise.Regimes.Command.Update;
using Contable.Application.EntitiesEnterprise.Regimes.Command.UpdateOne;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using Contable.Contractx.EnterpriseEntities.Commands.Regime;
using Contable.Domain.Enterprise.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Contable.Api.Controllers.EntitiesController.Commands;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Commands")]
public class RegimeController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public RegimeController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> CreateRegime(RegimeCreateDTO regimeCreateDTO)
    {
        var command = _mapper.Map<RegimeAddCommand>(regimeCreateDTO);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> DeleteRegime(Guid id)
    {
        var command = new RegimeDeleteCommand(id);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPut("Update/{id}")]
    public async Task<IActionResult> UpdateRegime(Guid id, RegimeUpdateDTO updateRegimeDTO)
    {
        var regime = _mapper.Map<Regime>(updateRegimeDTO);
        var command = new RegimeUpdateCommand(id, regime);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPatch("UpdateByOne/{id}")]
    public async Task<IActionResult> UpdateRegimeByOne(Guid id, RegimeUpdateDTO updateRegimeByOneDTO)
    {
        var regime = _mapper.Map<Regime>(updateRegimeByOneDTO);
        var command = new RegimeUpdateOneCommand(id, regime);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

}
