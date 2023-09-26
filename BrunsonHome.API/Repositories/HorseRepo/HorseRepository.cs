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
        var result = await _context.Horses.ToListAsync();
        return result;
    }

    public async Task<Horse> GetHorseById(int id)
    {
        var result = await _context.Horses
            .Where(i => i.Id == id)
            .Include(horse => horse.FootTrims)
            .Include(horse => horse.Wormings)
            .FirstOrDefaultAsync();
        
        if(result is null)
            throw new EntityNotFoundException($"Entity with id {id} was not found.");

        return result;
    }

    public async Task<HorseCreateRequest> CreateHorse(HorseCreateRequest request)
    {
        _context.Horses.Add(request.Adapt<Horse>());
        await _context.SaveChangesAsync();
        
        return request;
    }

    public async Task<Horse> UpdateHorse(HorseUpdateRequest request)
    {
        var ctxHorse = await _context.Horses.FindAsync(request.Id);
        if (ctxHorse is null)
            throw new EntityNotFoundException($"Entity with id {request.Id} was not found.");

        ctxHorse.BarnName = request.BarnName;
        ctxHorse.RegisteredName = request.RegisteredName;
        ctxHorse.PurchaseDate = request.PurchaseDate;
        ctxHorse.UpdateDate = DateTime.Now;
        await _context.SaveChangesAsync();

        return await GetHorseById(request.Id);
    }

    public async Task<HorseDeleteRequest> DeleteHorse(int id)
    {
        var ctxHorse = await _context.Horses.FindAsync(id);
        if (ctxHorse is null)
            throw new EntityNotFoundException($"Entity with id {id} was not found.");

        _context.Horses.Remove(ctxHorse);
        await _context.SaveChangesAsync();
        return ctxHorse.Adapt<HorseDeleteRequest>();
    }
}