using BrunsonHome.API.Repositories.WormingRepo;
using Microsoft.AspNetCore.Mvc;

namespace BrunsonHome.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WormingController : ControllerBase
{
    private readonly IWormingRepository _wormingRepo;

    public WormingController(IWormingRepository wormingRepository)
    {
        _wormingRepo = wormingRepository;
    }

    [HttpPost("AddWorming/{horseId}")]
    public async Task<ActionResult> AddWorming(int horseId, WormingRequest worming)
    {
        await _wormingRepo.AddWorming(horseId, worming);
        return Ok();
    }

    [HttpDelete("RemoveWorming/{horseId}")]
    public async Task<ActionResult> RemoveWorming(int horseId, int wormingId)
    {
        await _wormingRepo.RemoveWorming(horseId, wormingId);
        return Ok();
    }
}