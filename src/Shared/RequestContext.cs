namespace Shared;

public class RequestContext
{
    public HttpContext HttpContext { get; set; }
    public TracingContext TracingContext { get; set; }
    public Guid SubscriptionId { get; set; }
    public Guid UserId { get; set; }
}