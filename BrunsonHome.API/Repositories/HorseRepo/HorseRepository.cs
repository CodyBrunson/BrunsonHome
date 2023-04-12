using Mapster;

namespace BrunsonHome.API.Repositories.HorseRepo;

public class HorseRepository : IHorseRepository
{
    private readonly DataContext _context;

    public HorseRepository(DataContext context)
    {
        _context = context;
    }
    public async Task<List<Horse>> GetAllHorses()
    {
        return await _context.Horses.ToListAsync();
    }

    public async Task<Horse?> GetHorseById(int id)
    {
        var result = await _context.Horses.FindAsync(id);
        return result;
    }

    public async Task<HorseCreateRequest> CreateHorse(HorseCreateRequest request)
    {
        _context.Horses.Add(request.Adapt<Horse>());
        await _context.SaveChangesAsync();
        
        return request;
    }
}