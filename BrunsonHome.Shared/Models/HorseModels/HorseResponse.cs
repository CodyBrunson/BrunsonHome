namespace BrunsonHome.Shared.Models.HorseModels;

public record struct HorseResponse(
    int Id,
    string BarnName, 
    string RegisteredName,
    DateTime PurchaseDate,
    DateTime AddDate
    );