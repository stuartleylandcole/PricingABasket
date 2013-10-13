using System.Collections.Generic;
using PricingABasket.Offers;
using PricingABasket.items;

namespace PricingABasket.Pricing
{
    public class PriceCalculator
    {
        private readonly IEnumerable<IItem> _items;
        private readonly IEnumerable<IOffer> _offers;

        public PriceCalculator(IEnumerable<IItem> items, IEnumerable<IOffer> offers)
        {
            _items = items;
            _offers = offers;
        }

        public PricerResult CalculateTotal()
        {
            return new PricerResult(0.00m, new List<OfferAndSaving>(), 0.00m);
        }
    }
}
