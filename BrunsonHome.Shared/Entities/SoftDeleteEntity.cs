namespace BrunsonHome.Shared.Entities;

public class SoftDeleteEntity : BaseEntity
{
    public bool isDeleted { get; set; } = false;
    public DateTime? DateDeleted { get; set; }
}