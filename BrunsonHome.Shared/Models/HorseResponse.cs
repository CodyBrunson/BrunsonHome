namespace BrunsonHome.Shared.Models;

public record struct HorseResponse(
    int Id,
    string BarnName, 
    string RegisteredName,
    DateTime AddDate
    );