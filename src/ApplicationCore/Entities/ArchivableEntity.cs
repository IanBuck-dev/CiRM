namespace ApplicationCore.Entities;

public class ArchivableEntity<T> : SubscriptionSpecificEntity<T>
{
    public bool IsArchived { get; set; }
}