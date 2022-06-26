namespace ApplicationCore.Entities;

public class SubscriptionSpecificEntity<T> : BaseEntity<T>
{
    public Guid SubscriptionId { get; set; }
}