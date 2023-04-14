namespace BrunsonHome.API.Repositories.WormingRepo;

public class WormingRepository : IWormingRepository
{
    private readonly DataContext _context;
    public WormingRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task AddWorming(int horseId, WormingRequest worming)
    {
        var ctxHorse = await _context.Horses.FindAsync(horseId);
        if (ctxHorse is null)
            throw new EntityNotFoundException($"Entity with the id {horseId} was not found.");

        ctxHorse.Wormings.Add(worming.Adapt<Worming>());
        ctxHorse.RecentWorming = ctxHorse.Wormings.Last();
        ctxHorse.UpdateDate = DateTime.Now;
        await _context.SaveChangesAsync();
    }

    public async Task RemoveWorming(int horseId, int wormingId)
    {
        var ctxWorming = await _context.Wormings.FindAsync(wormingId);
        var ctxHorse = await _context.Horses            
            .Where(i => i.Id == horseId)
            .Include(horse => horse.Wormings)
            .FirstOrDefaultAsync();
        
        if(ctxWorming is null) 
            throw new EntityNotFoundException($"Entity with id {wormingId} was not found.");
        
        if(ctxHorse is null) 
            throw new EntityNotFoundException($"Entity with id {horseId} was not found.");

        if (ctxHorse.RecentWorming is null)
        {
            throw new NoWormingFoundException("Unable to delete worming as the horse does seem to have a recent worming record.");
        }

        if (ctxHorse.RecentWorming.Id == wormingId && ctxHorse.Wormings.Contains(ctxWorming))
        {
            _context.Wormings.Remove(ctxWorming);
            ctxHorse.RecentWorming = ctxHorse.Wormings.Last();
            ctxHorse.UpdateDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return;
        }
        
        _context.Wormings.Remove(ctxWorming);
        ctxHorse.UpdateDate = DateTime.Now;
        
        await _context.SaveChangesAsync();
    }
}