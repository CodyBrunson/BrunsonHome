namespace BrunsonHome.Shared.Entities;

public class Worming : SoftDeleteEntity
{
    public string Product { get; set; }
    public DateTime WormingDate { get; set; }
}