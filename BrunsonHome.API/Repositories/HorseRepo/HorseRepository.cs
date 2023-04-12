using Mapster;

namespace BrunsonHome.API.Repositories.HorseRepo;

public class HorseRepository : IHorseRepository
{
    private static readonly List<Horse> Horses = new List<Horse>()
    {
        new Horse()
        {
            Id = 1,
            BarnName = "Willow",
            RegisteredName = "Not Sure"
        }
    };
    public async Task<List<HorseResponse>> GetAllHorses()
    {
        return  Horses.Adapt<List<HorseResponse>>();
    }
}