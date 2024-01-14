
using Microsoft.AspNetCore.Mvc;
using NannoA_MiniChallengeEightToTen___Endpoints.Services.RestaurantPicker;


namespace NannoA_MiniChallengeEightToTen___Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : Controller
{
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
    {
        _restaurantPickerService = restaurantPickerService;
    }
    [HttpGet]
    [Route("Enter restaurant number: 1-Fast food; 2-Asian Restaurants; 3-Latin American Restaurants/{Enter_Number_1_or_2_or_3_Only}")]
    public string RestaurantPicker(string Enter_Number_1_or_2_or_3_Only)
    {
        return _restaurantPickerService.RestaurantPicker(Enter_Number_1_or_2_or_3_Only);
    }
}
