using StripePaymentGateway.Models;
using StripePaymentGateway.PaymentProcessing;
using System;

namespace StripePaymentGateway.Handlers
{
    public class StripePaymentHandler : IHandler<Order>
    {
        public void Handle(Order request)
        {
            throw new NotImplementedException();
        }
    }
}
