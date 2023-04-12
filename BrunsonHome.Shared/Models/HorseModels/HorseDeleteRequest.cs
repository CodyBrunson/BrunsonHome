namespace BrunsonHome.Shared.Models.HorseModels;

public record HorseDeleteRequest(
    int Id,
    string BarnName,
    string RegisteredName
    );