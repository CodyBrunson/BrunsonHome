namespace BrunsonHome.API.Repositories.FootTrimRepo;

public interface IFootTrimRepository
{
    Task AddTrimToHorse(int Id);
    Task RemoveTrimFromHorse(int trimId, int horseId);
}