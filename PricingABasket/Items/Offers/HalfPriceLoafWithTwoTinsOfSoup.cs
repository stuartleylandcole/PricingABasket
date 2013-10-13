using System;
using System.Collections.Generic;
using System.Linq;

namespace PricingABasket.Items.Offers
{
    public class HalfPriceLoafWithTwoTinsOfSoup : IOffer
    {
        public string Description
        {
            get { return "Buy 2 tins of soup and get a loaf of bread for half price"; }
        }

        public decimal Discount
        {
            get { return new Bread().Price*0.5m; }
        }

        public int NumberOfTimesApplicable(IList<IItem> items)
        {
            var numberOfLoaves = items.Count(i => i is Bread);
            if (numberOfLoaves == 0)
            {
                return 0;
            }

            var numberOfTinsOfSoup = items.Count(i => i is Soup);
            if (numberOfTinsOfSoup == 0)
            {
                return 0;
            }

            //if they have bought 3 tins of soup then they can only have this offer once.
            var maximumNumberOfTimesToApply = numberOfTinsOfSoup/2;
            return Math.Min(maximumNumberOfTimesToApply, numberOfLoaves);
        }
    }
}
