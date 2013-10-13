using System.Collections.Generic;
using System.Linq;

namespace PricingABasket.Items.Offers
{
    public class AppleTenPercentDiscount : IOffer
    {
        public string Description
        {
            get { return "Apples 10% off"; }
        }

        public int NumberOfTimesApplicable(IList<IItem> items)
        {
            return items.Count(i => i is Apples);
        }

        public decimal Discount
        {
            get { return new Apples().Price * 0.1m; }
        }
    }
}
