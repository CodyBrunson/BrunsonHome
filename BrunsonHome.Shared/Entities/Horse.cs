namespace BrunsonHome.Shared.Entities;

public class Horse : SoftDeleteEntity
{
    public required string BarnName { get; set; }
    public string? RegisteredName { get; set; }
    public DateTime? PurchaseDate { get; set; }
    public List<FootTrim> FootTrims { get; set; } = new List<FootTrim>();
    public FootTrim? RecentTrim { get; set; }
    public List<Worming> Wormings { get; set; } = new List<Worming>();
    public Worming? RecentWorming { get; set; }
}