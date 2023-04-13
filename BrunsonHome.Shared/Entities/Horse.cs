namespace BrunsonHome.Shared.Entities;

public class Horse
{
    public int Id { get; set; }
    public required string BarnName { get; set; }
    public string? RegisteredName { get; set; }
    public DateTime? PurchaseDate { get; set; }
    public DateTime AddDate { get; set; } = DateTime.Now;
    public DateTime? UpdateDate { get; set; }
    public List<FootTrim> FootTrims { get; set; } = new List<FootTrim>();
    public FootTrim? RecentTrim { get; set; }
}