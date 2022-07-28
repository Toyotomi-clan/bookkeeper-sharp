using Microsoft.AspNetCore.Mvc;

namespace Bookkeeper.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class InvoicesController : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetId([FromRoute]int id)
    {
        return Ok(id);
    }
}
