namespace BrunsonHome.Shared.Entities;

public class FootTrim : SoftDeleteEntity
{
    public DateTime TrimDate { get; set; } = DateTime.Now;
}