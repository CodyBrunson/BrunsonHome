namespace BrunsonHome.API.Repositories.WormingRepo;

public interface IWormingRepository
{
    public Task AddWorming(int horseId, WormingRequest worming);
    public Task RemoveWorming(int horseId, int wormingId);
}