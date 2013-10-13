using System.Collections.Generic;
using System.Linq;
using PricingABasket.Items;
using PricingABasket.Items.Offers;

namespace PricingABasket.Calculator
{
    public class PriceCalculator
    {
        private readonly IList<IItem> _items;
        private readonly IList<IOffer> _offers;

        public PriceCalculator(IList<IItem> items, IList<IOffer> offers)
        {
            _items = items;
            _offers = offers;
        }

        public CalculatorResult Calculate()
        {
            var subtotal = CalculateSubtotal();
            var offerSavings = CalculateOfferSavings();
            var total = CalculateTotal(subtotal, offerSavings);
            return new CalculatorResult(subtotal, offerSavings, total);
        }

        private decimal CalculateSubtotal()
        {
            return _items.Sum(i => i.Price);
        }

        private IList<OfferSaving> CalculateOfferSavings()
        {
            var offerSavings = new List<OfferSaving>();
            offerSavings.AddRange(from offer in _offers 
                                  let numberOfTimesApplicable = offer.NumberOfTimesApplicable(_items) 
                                  where numberOfTimesApplicable > 0 
                                  select new OfferSaving(offer, numberOfTimesApplicable*offer.Discount)
                                  );

            return offerSavings;
        }

        private decimal CalculateTotal(decimal subtotal, IEnumerable<OfferSaving> offerSavings)
        {
            return subtotal - offerSavings.Sum(os => os.Saving);
        }
    }
}
