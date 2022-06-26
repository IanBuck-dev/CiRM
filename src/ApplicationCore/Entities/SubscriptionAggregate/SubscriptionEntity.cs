namespace ApplicationCore.Entities.SubscriptionAggregate;

public class SubscriptionEntity : BaseEntity<Guid>
{
    public string Name { get; set; } = "default";
    public int BookedLicenses { get; set; }
    public int UsedLicenses { get; set; }
    public string ExternalSubscriptionId { get; set; }
}