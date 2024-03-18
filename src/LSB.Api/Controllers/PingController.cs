using LSCore.Contracts.Http;
using Microsoft.AspNetCore.Mvc;

namespace LSB.Api.Controllers;

[ApiController]
public class PingController : ControllerBase
{
    public PingController()
    {
        
    }
    
    [HttpGet]
    [Route("/ping")]
    public LSCoreResponse<string> Get() =>
        new LSCoreResponse<string>("Pong");
}