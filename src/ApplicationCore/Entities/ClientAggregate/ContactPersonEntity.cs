namespace ApplicationCore.Entities.ClientAggregate;

public class ContactPersonEntity : SubscriptionSpecificEntity<Guid>
{
    public string Name { get; set; }
    public ClientEntity Client { get; set; }
}