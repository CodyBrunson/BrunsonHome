namespace BrunsonHome.Shared.Models.WormingModels;

public record struct WormingRequest(
    string Product,
    DateTime WormingDate
    );