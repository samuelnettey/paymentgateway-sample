namespace StripePaymentGateway.Models.Subscriptions
{
    public class StripeSubscription
    {
        public string StripePlanId { get; set; }
        public string StripeCustomerId { get; set; }
        public string StripeSubscriptionId { get; set; }
    }
}
