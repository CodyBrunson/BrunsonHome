using BrunsonHome.API.Repositories.FootTrimRepo;
using Microsoft.AspNetCore.Mvc;

namespace BrunsonHome.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FootTrimController : ControllerBase
{
    private readonly IFootTrimRepository _footTrimRepository;

    public FootTrimController(IFootTrimRepository footTrimRepository)
    {
        _footTrimRepository = footTrimRepository;
    }
    
    [HttpPost("AddTrim/{trimId}")]
    public async Task<ActionResult> AddTrimToHorse(int trimId)
    {
        try
        {
            await _footTrimRepository.AddTrimToHorse(trimId);
        }
        catch (EntityNotFoundException)
        {
            return NotFound(
                $"No horse with the id {trimId} has been created.  Please create this horse before adding a new trim.");
        }

        return Ok($"Trim added to horse with id {trimId}");
    }
    
    [HttpDelete("RemoveTrim/{trimId}")]
    public async Task<ActionResult> DeleteTrimFromHorse(int trimId, int horseId)
    {
        try
        {
            await _footTrimRepository.RemoveTrimFromHorse(trimId, horseId);
        }
        catch (EntityNotFoundException)
        {
            return NotFound(
                $"Unable to delete trim {trimId} from horse.");
        }

        return Ok($"Trim with id {trimId} deleted from horse.");
    }
}