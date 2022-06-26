namespace ApplicationCore.Entities.ClientAggregate;

/// <summary>
/// Root of the client aggregate.
/// </summary>
public class ClientEntity : SubscriptionSpecificEntity<Guid>
{
    public string Name { get; set; }
    public virtual IEnumerable<ContactPersonEntity> ContactPersons { get; set; }
}