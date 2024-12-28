using Contable.Domain.Enterprise;
using Contable.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contable.Api.Controllers.Enterprise.Queries;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Queries")]
public class EnterpriseQueriesController : ControllerBase
{
    private readonly ContextContable _contextContable;

    public EnterpriseQueriesController(ContextContable contextContable)
    {
        _contextContable = contextContable;
    }

    [HttpGet]
    public async Task<IEnumerable<Enterprises>> GetEnterprises()
    {
        return await _contextContable.Enterprises.ToListAsync();
    }
}
