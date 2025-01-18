using AutoMapper;
using Contable.Application.EntitiesEnterprise.EmployeesC.Command.Add;
using Contable.Application.EntitiesEnterprise.EmployeesC.Command.Delete;
using Contable.Application.EntitiesEnterprise.EmployeesC.Command.Update;
using Contable.Application.EntitiesEnterprise.EmployeesC.Command.UpdateOne;
using Contable.Application.Services.Interfaces.Persistence.EntitiesEnterpriseRepository.Commands;
using Contable.Contractx.EnterpriseEntities.Commands.EmployeesCompany;
using Contable.Domain.Enterprise.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contable.Api.Controllers.EntitiesController.Commands;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Commands")]
public class EmployeesCompanyController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public EmployeesCompanyController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> CreateEmployeesCompany(ECCreateDTO employeesCompanyCreateDTO)
    {
        var command = _mapper.Map<EmployeesCompanyAddCommand>(employeesCompanyCreateDTO);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> DeleteEmployeesCompany(Guid id)
    {
        var command = new EmployeesCompanyDeleteCommand(id);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPut("Update/{id}")]
    public async Task<IActionResult> UpdateEmployeesCompany(Guid id, ECUpdateDTO updateEmployeesCompanyDTO)
    {
        var employeesCompany = _mapper.Map<EmployeesCompany>(updateEmployeesCompanyDTO);
        var command = new EmployeesCompanyUpdateCommand(id, employeesCompany);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPatch("UpdateByOne/{id}")]
    public async Task<IActionResult> UpdateEmployeesCompanyByOne(Guid id, ECUpdateDTO updateEmployeesCompanyByOneDTO)
    {
        var employeesCompany = _mapper.Map<EmployeesCompany>(updateEmployeesCompanyByOneDTO);
        var command = new EmployeesCompanyUpdateOneCommand(id, employeesCompany);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

}
