namespace StripePaymentGateway.PaymentProcessing
{
    public interface IHandler<T> where T : class
    {
        void Handle(T request);
    }
}
