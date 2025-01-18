using AutoMapper;
using Contable.Application.EntitiesEnterprise.Enterprise.Command.Add;
using Contable.Application.EntitiesEnterprise.Enterprise.Command.Detele;
using Contable.Application.EntitiesEnterprise.Enterprise.Command.Update;
using Contable.Application.EntitiesEnterprise.Enterprise.Command.UpdateByOne;
using Contable.Contractx.Enterprise.Commands;
using Contable.Domain.Enterprise;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.Enterprise.Commands;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Commands")]
public class EnterpriseCommandController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public EnterpriseCommandController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> AddEnterprise(AddEnterpriseDTO addEnterpriseDTO)
    {
        var command = _mapper.Map<EnterpriseAddCommand>(addEnterpriseDTO);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEnterprise(Guid id)
    {
        var command = new EnterpriseDeleteCommand(id);
        var result = await _mediator.Send(command);
        return Ok(result);
    }



    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEnterprise(Guid id, AddEnterpriseDTO updateEnterpriseDTO)
    {
        var enterprise = _mapper.Map<Enterprises>(updateEnterpriseDTO);
        var command = new EnterpriseUpdateCommand(id, enterprise);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateEnterpriseByOne(Guid id, AddEnterpriseDTO updateEnterpriseByOneDTO)
    {
        var enterprise = _mapper.Map<Enterprises>(updateEnterpriseByOneDTO);
        var command = new EnterpriseUpdateOneCommand(id, enterprise);
        var result = await _mediator.Send(command);
        return Ok(result);
    }


}
