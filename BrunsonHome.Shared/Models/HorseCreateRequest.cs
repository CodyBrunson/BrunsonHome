namespace BrunsonHome.Shared.Models;

public record struct HorseCreateRequest(
    string BarnName,
    string? RegisteredName,
    DateTime? PurchaseDate
);