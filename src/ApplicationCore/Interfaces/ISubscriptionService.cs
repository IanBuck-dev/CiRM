using ApplicationCore.Entities;
using ApplicationCore.Entities.SubscriptionAggregate;
using ApplicationCore.Entities.SubscriptionAggregate.Forms;
using FluentResults;
using Shared;

namespace ApplicationCore.Interfaces;

public interface ISubscriptionService
{
    Task<Result<SubscriptionEntity>> CreateSubscription(SubscriptionForm form, RequestContext context);
    Task<Result<SubscriptionEntity>> UpdateSubscription(SubscriptionForm form, RequestContext context);
    Task<Result> DeleteSubscription(Guid subscriptionId, RequestContext context);
}