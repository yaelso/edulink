using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using yaelso.edulink.Database.Models;

namespace yaelso.edulink.Api.Controllers;

[ApiController]
[Route("link")]
public class LinkController : ControllerBase
{
    private readonly ILogger<LinkController> _log;

    public LinkController(ILogger<LinkController> log)
    {
        _log = log;
    }

    [HttpPost]
    public async Task<IActionResult> Post()
    {
        // TODO: write a Link record to the database

        // Return a non-failure result since the request didn't explicitly fail
        return new NoContentResult();
    }
    
    [HttpGet("user/{userId:int}")]
    public async Task<IActionResult> GetAll(int userId)
    {
        // TODO: fetch all links from the database

        // Return an empty collection for now since we have nothing to give the user
        return new OkObjectResult(Enumerable.Empty<Link>());
    }

    [HttpDelete("{linkId:int")]
    public async Task<IActionResult> Delete(int linkId)
    {
        // TODO: delete a record from the database
        
        // Return a non-failure result since the request didn't explicitly fail
        return new NoContentResult();
    }
}