using System.Collections.Generic;

namespace PricingABasket.Items.Offers
{
    public interface IOffer
    {
        string Description { get; }
        decimal Discount { get; }
        int NumberOfTimesApplicable(IList<IItem> items);
    }
}
