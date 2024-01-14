
using System.Reflection.Emit;
using Microsoft.AspNetCore.Mvc;
using NannoA_MiniChallengeEightToTen___Endpoints.Services.Magic8Ball;

namespace NannoA_MiniChallengeEightToTen___Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    private readonly IMagic8BallService _magic8BallService;

    public Magic8BallController(IMagic8BallService magic8BallService)
    {
        _magic8BallService = magic8BallService;
    }
    [HttpGet]
    [Route("Ask your question and press execute")]
    public string Magic8Ball()
    {
        return _magic8BallService.Magic8Ball();
    }
}
