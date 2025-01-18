using AutoMapper;
using Contable.Application.EntitiesEnterprise.Contactos.Command.Delete;
using Contable.Application.EntitiesEnterprise.Contactos.Command.Update;
using Contable.Application.EntitiesEnterprise.Contactos.Command.UpdateOne;
using Contable.Application.EntitiesEnterprise.Contactos.Commands.Add;
using Contable.Contractx.EnterpriseEntities.Commands.Contacts;
using Contable.Domain.Enterprise.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.EntitiesController.Commands;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Commands")]
public class ContactsController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public ContactsController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> CreateContacts(ContactsCreateDTO contactsCreateDTO)
    {
        var command = _mapper.Map<ContactsAddCommand>(contactsCreateDTO);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> DeleteContacts(Guid id)
    {
        var command = new ContactsDeleteCommand(id);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPut("Update/{id}")]
    public async Task<IActionResult> UpdateContacts(Guid id, ContactsUpdateDTO updateContactsDTO)
    {
        var contacts = _mapper.Map<Contacts>(updateContactsDTO);
        var command = new ContactsUpdateCommand(id, contacts);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPatch("UpdateByOne/{id}")]
    public async Task<IActionResult> UpdateContactsByOne(Guid id, ContactsCreateDTO updateContactsByOneDTO)
    {
        var contacts = _mapper.Map<Contacts>(updateContactsByOneDTO);
        var command = new UpdateOneCommand(id, contacts);
        var result = await _mediator.Send(command);
        return Ok(result);
    }




}
