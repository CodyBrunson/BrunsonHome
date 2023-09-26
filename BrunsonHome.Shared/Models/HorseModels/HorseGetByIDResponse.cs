using BrunsonHome.Shared.Entities;

namespace BrunsonHome.Shared.Models.HorseModels;

public record struct HorseGetByIDResponse(
    string BarnName,
    string RegisteredName,
    DateTime? PurchaseDate,
    FootTrim? RecentTrim,
    Worming? RecentWorming
);
