
using Microsoft.AspNetCore.Mvc;
using NannoA_MiniChallengeEightToTen___Endpoints.Services.GuessIt;

namespace NannoA_MiniChallengeEightToTen___Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpGet]
    [Route("Easy_level_Numbers_from_1-10/{InputNumber}")]
    public string EasyGuess(string InputNumber)
    {
        return _guessItService.EasyGuess(InputNumber);
    }
    [HttpGet]
    [Route("Medium_level_Numbers_from_1-50/{InputNumber}")]
    public string MediumGuess(string InputNumber)
    {
        return _guessItService.MediumGuess(InputNumber);
    }

    [HttpGet]
    [Route("Hard_level_Numbers_from_1-100/{InputNumber}")]
    public string HardGuess(string InputNumber)
    {
        return _guessItService.HardGuess(InputNumber);
    }
}
