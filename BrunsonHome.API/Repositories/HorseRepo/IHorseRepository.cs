namespace BrunsonHome.API.Repositories.HorseRepo;

public interface IHorseRepository
{
    Task<List<Horse>> GetAllHorses();
    Task<Horse> GetHorseById(int id);
    Task<HorseCreateRequest> CreateHorse(HorseCreateRequest request);
    Task<Horse> UpdateHorse(HorseUpdateRequest request);
    Task<HorseDeleteRequest> DeleteHorse(int id);
}