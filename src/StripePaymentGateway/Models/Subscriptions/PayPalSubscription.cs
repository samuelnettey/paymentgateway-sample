namespace StripePaymentGateway.Models.Subscriptions
{
    public class PayPalSubscription : Subscription
    {
        public string PayPalPlanId { get; set; }
        public string PayPalAgreementToken { get; set; }
        public string PayPalAgreementId { get; set; }
    }
}
