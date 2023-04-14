namespace BrunsonHome.Shared.Models.HorseModels;

public record struct HorseUpdateRequest(
    int Id,
    string BarnName,
    string RegisteredName,
    DateTime PurchaseDate
);