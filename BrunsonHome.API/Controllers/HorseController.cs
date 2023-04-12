using Microsoft.AspNetCore.Mvc;

namespace BrunsonHome.API.Controllers;

public class HorseController : ControllerBase
{

    [HttpGet]
    public ActionResult<List<HorseResponse>> GetAllHorses()
    {
        return Ok();
    }

}