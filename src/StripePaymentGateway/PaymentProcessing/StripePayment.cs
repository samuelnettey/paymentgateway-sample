using Stripe;
using System;
using System.Threading.Tasks;
using Order = StripePaymentGateway.Models.Order;

namespace StripePaymentGateway.PaymentProcessing
{
    public class StripePayment : IPaymentProcessor
    {
        public void Finalize(Order order)
        {
            throw new NotImplementedException();
        }


        private void StripeSubcriptionCharges()
        {
            StripeCustomerCreateOptions ss = new StripeCustomerCreateOptions();
        }
        public async Task<dynamic> PayAsync(string cardNumber, int month, int year, string cvc, int value)
        {
            try
            {

                StripeConfiguration.ApiKey = "sk_test_5c9O1EiPCGqYWXGXO31PY1I200lvNHeZKx";

                var optionsToken = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = cardNumber,
                        ExpMonth = month,
                        ExpYear = year,
                        Cvc = cvc

                    },

                };
                var serviceToken = new TokenService();
                Token stripeToken = await serviceToken.CreateAsync(optionsToken);

                var options = new ChargeCreateOptions
                {
                    Amount = value,
                    Currency = "eur",
                    Description = "Test",
                    Source = stripeToken.Id
                };

                var service = new ChargeService();
                Charge charge = await service.CreateAsync(options);

                return charge.Paid ? "success" : "failed";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
