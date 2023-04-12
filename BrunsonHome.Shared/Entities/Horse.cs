namespace BrunsonHome.Shared.Entities;

public record struct Horse(
    int Id,
    string BarnName,
    string RegisteredName
);