using Microsoft.AspNetCore.Mvc;

namespace mashrahAReverseitEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
[HttpGet]
    [Route("ReverseIt")]

    public string ReverseIt()
    {
        return " it will reverse the users input";
    }
}