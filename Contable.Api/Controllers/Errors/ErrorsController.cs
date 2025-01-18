using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;

namespace Contable.Api.Controllers.Errors;

[ApiController]
[ApiExplorerSettings(GroupName = "System")]

public class ErrorController : ControllerBase
{

    [HttpGet, HttpPost, HttpPut, HttpDelete, HttpPatch, HttpOptions]
    [Route("/error")]
    public IActionResult HandleError()
    {
        var statusCode = HttpContext.Response.StatusCode;
        var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();

        if (exceptionFeature?.Error is ValidationException validationException)
        {
            return BadRequest(new
            {
                message = "Validation failed",
                errors = GetValidationErrors(validationException)
            });
        }

        return StatusCode(statusCode, new { message = "An error occurred", error = exceptionFeature?.Error.Message });
    }

    private IEnumerable<string> GetValidationErrors(ValidationException validationException)
    {
        foreach (var failure in validationException.Errors)
        {
            yield return $"{failure.PropertyName}: {failure.ErrorMessage}";
        }
    }

}

