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
    
    [HttpGet("GetAllHorses")]
    public async Task<ActionResult<List<HorseResponse>>> GetAllHorses()
    {
        var result = await _horseRepository.GetAllHorses();
        return Ok(result.Adapt<List<HorseResponse>>());
    }
    
    [HttpGet("GetHorseById/{id}")]
    public async Task<ActionResult<Horse>> GetHorseById(int id)
    {
        var result = await _horseRepository.GetHorseById(id);
        if (result is null)
        {
            return NotFound("Horse with given id " + id + " does not exist.");
        }
        return Ok(result);
    }

    [HttpPost("CreateNewHorse")]
    public async Task<ActionResult<HorseCreateRequest>> CreateHorse(HorseCreateRequest request)
    {
        return Ok(await _horseRepository.CreateHorse(request));
    }

    [HttpPut("UpdateHorse/{id}")]
    public async Task<ActionResult<HorseUpdateRequest>> UpdateHorse(int id, HorseUpdateRequest request)
    {
        try
        {
            var result = await _horseRepository.UpdateHorse(id, request);
            return Ok(result);
        }
        catch (EntityNotFoundException)
        {
            return NotFound($"Horse with id {id} is not found.");
        }
    }

    [HttpDelete("DeleteHorse/{id}")]
    public async Task<ActionResult<HorseDeleteRequest>> DeleteHorse(int id)
    {
        try
        {
            var result = await _horseRepository.DeleteHorse(id);
            return Ok(result);
        }
        catch (EntityNotFoundException)
        {
            return NotFound($"Horse with id {id} is not found.");
        }
    }

}