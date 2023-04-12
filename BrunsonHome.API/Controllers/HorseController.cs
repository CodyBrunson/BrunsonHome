using BrunsonHome.API.Repositories.HorseRepo;
using Microsoft.AspNetCore.Mvc;

namespace BrunsonHome.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HorseController : ControllerBase
{

    private readonly IHorseRepository _horseRepository;

    public HorseController(IHorseRepository horseRepository)
    {
        _horseRepository = horseRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Horse>>> GetAllHorses()
    {
        var result = await _horseRepository.GetAllHorses();
        return Ok(result);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<List<Horse>>> GetHorseById(int id)
    {
        var result = await _horseRepository.GetHorseById(id);
        if (result is null)
        {
            return NotFound("Horse with given id " + id + " does not exist.");
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<HorseCreateRequest>> CreateHorse(HorseCreateRequest request)
    {
        return Ok(await _horseRepository.CreateHorse(request));
    }

}