namespace BrunsonHome.API.Repositories.HorseRepo;

public interface IHorseRepository
{
    Task<List<HorseResponse>> GetAllHorses();
}