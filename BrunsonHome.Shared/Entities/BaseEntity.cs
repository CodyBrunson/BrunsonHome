namespace BrunsonHome.Shared.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime AddDate { get; set; } = DateTime.Now;
    public DateTime? UpdateDate { get; set; }
}