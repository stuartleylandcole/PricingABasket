using System.Collections.Generic;
using PricingABasket.Offers;

namespace PricingABasket.Pricing
{
    public class PricerResult
    {
        public decimal SubTotal { get; private set; }
        public IEnumerable<OfferAndSaving> ApplicableOffers { get; private set; }
        public decimal Total { get; private set; }

        public PricerResult(decimal subTotal, IEnumerable<OfferAndSaving> applicableOffers, decimal total)
        {
            SubTotal = subTotal;
            ApplicableOffers = applicableOffers;
            Total = total;
        }
    }
}
