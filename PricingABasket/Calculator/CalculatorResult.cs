using System.Collections.Generic;

namespace PricingABasket.Calculator
{
    public class CalculatorResult
    {
        public decimal SubTotal { get; private set; }
        public IEnumerable<OfferSaving> ApplicableOffers { get; private set; }
        public decimal Total { get; private set; }

        public CalculatorResult(decimal subTotal, IEnumerable<OfferSaving> applicableOffers, decimal total)
        {
            SubTotal = subTotal;
            ApplicableOffers = applicableOffers;
            Total = total;
        }
    }
}
