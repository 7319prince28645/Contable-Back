using Contable.Infrastructure.Persistence;
using Domain.Payment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Contable.Api.Controllers.Payment.Queries;

[Route("api/[controller]")]
[ApiController]
[ApiExplorerSettings(GroupName = "Queries")]
public class PaymentQueryController : ControllerBase
{
    private readonly ContextContable _context;

    public PaymentQueryController(ContextContable context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Payments>>> GetPayments()
    {
        return await _context.Payments.ToListAsync();
    }

}
