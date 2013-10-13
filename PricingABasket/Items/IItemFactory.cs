using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PricingABasket.items;

namespace PricingABasket.Items
{
    public interface IItemFactory
    {
        IItem CreateItem(string description);
    }
}
