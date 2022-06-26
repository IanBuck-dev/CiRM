namespace ApplicationCore.Entities;

public abstract class BaseEntity<T>
{
    public T Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime UpdatedOn { get; set; }
    public Guid UpdatedBy { get; set; }
    public DateTime DeletedOn { get; set; }
    public Guid DeletedBy { get; set; }
}