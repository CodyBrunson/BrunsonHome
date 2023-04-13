namespace BrunsonHome.API.Repositories.FootTrimRepo;

public class FootTrimRepository : IFootTrimRepository
{
    private readonly DataContext _context;

    public FootTrimRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task AddTrimToHorse(int Id)
    {
        var ctxHorse = await _context.Horses.FindAsync(Id);
        if(ctxHorse is null) 
            throw new EntityNotFoundException($"Entity with id {Id} was not found.");
        
        ctxHorse.FootTrims.Add(new FootTrim());
        ctxHorse.RecentTrim = ctxHorse.FootTrims.Last();
        ctxHorse.UpdateDate = DateTime.Now;
        
        await _context.SaveChangesAsync();
    }

    public async Task RemoveTrimFromHorse(int trimId, int horseId)
    {
        var ctxFootTrim = await _context.FootTrims.FindAsync(trimId);
        var ctxHorse = await _context.Horses            
            .Where(i => i.Id == horseId)
            .Include(horse => horse.FootTrims)
            .FirstOrDefaultAsync();
        if(ctxFootTrim is null || ctxHorse is null) 
            throw new EntityNotFoundException($"Entity with id {trimId} was not found.");

        if (ctxHorse.RecentTrim is null)
        {
            throw new NoTrimsFoundException("Unable to delete trim as the horse it belongs to has never been trimmed.");
        }

        if (ctxHorse.RecentTrim.Id == trimId && ctxHorse.FootTrims.Contains(ctxFootTrim))
        {
            _context.FootTrims.Remove(ctxFootTrim);
            ctxHorse.RecentTrim = ctxHorse.FootTrims.Last();
            ctxHorse.UpdateDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return;
        }
        
        _context.FootTrims.Remove(ctxFootTrim);
        ctxHorse.UpdateDate = DateTime.Now;
        await _context.SaveChangesAsync();
    }
}