﻿namespace StripePaymentGateway.Models
{
    public class Payment
    {

        public string CardNumber { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Cvc { get; set; }
        public int Value { get; set; }

    }
}
