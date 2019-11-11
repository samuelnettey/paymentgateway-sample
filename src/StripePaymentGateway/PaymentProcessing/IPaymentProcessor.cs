using StripePaymentGateway.Models;

namespace StripePaymentGateway.PaymentProcessing
{
    public interface IPaymentProcessor
    {
        void Finalize(Order order);
    }
}
