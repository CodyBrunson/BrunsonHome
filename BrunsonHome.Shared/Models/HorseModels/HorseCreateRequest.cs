namespace BrunsonHome.Shared.Models.HorseModels;

public record struct HorseCreateRequest(
    string BarnName,
    string? RegisteredName,
    DateTime? PurchaseDate
);