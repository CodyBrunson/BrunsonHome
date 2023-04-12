namespace BrunsonHome.Shared.Models.HorseModels;

public record struct HorseUpdateRequest(
    string BarnName,
    string RegisteredName,
    DateTime PurchaseDate
);