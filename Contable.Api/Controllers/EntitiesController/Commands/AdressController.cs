using AutoMapper;
using Contable.Application.EntitiesEnterprise.Adress.Command.Add;
using Contable.Application.EntitiesEnterprise.Adress.Command.Delete;
using Contable.Application.EntitiesEnterprise.Adress.Command.Update;
using Contable.Application.EntitiesEnterprise.Adress.Command.UpdateOne;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using Contable.Contractx.EnterpriseEntities.Commands.Adress;
using Contable.Domain.Enterprise.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.EntitiesController.Commands;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Commands")]
public class AdressController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public AdressController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> CreateAdress(AdressCreateDTO adressCreateDTO)
    {
        var command = _mapper.Map<AdressAddCommand>(adressCreateDTO);
        var result = await _mediator.Send(command);

        return Ok(result);
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> DeleteAdress(Guid id)
    {
        var command = new AdressDeleteCommand(id);
        var result = await _mediator.Send(command);
        return Ok(result);
    }


    [HttpPut("Update/{id}")]
    public async Task<IActionResult> UpdateAdress(Guid id,  AdressUpdateDTO updateAdressDTO)
    {
        var adress = _mapper.Map<Adrress>(updateAdressDTO);
        var command = new AdressUpdateCommand(id, adress);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

   
    [HttpPatch("UpdateByOne/{id}")]
    public async Task<IActionResult> UpdateAdressByOne(Guid id, AdressUpdateDTO updateAdressByOneDTO)
    {
        var adress = _mapper.Map<Adrress>(updateAdressByOneDTO);
        var command = new AdressUpdateOneCommand(id, adress);
        var result = await _mediator.Send(command);
        return Ok(result);
    }


}
