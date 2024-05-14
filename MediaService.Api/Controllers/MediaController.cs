using System;
using Microsoft.AspNetCore.Mvc;

namespace MediaService.Api;

[ApiController]
[Route("api/public/[controller]")]
public class MediaController : ControllerBase
{
    [HttpGet("stream")]
    public IActionResult GetMediaStream()
    {
        var bytes = new byte[100];
        
        // generate random bytes to imitate a workload
        var random = new Random();
        random.NextBytes(bytes);

        return Ok(string.Join(" ", bytes));
    }
}
