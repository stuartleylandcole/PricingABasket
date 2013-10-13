using System;
using System.Collections.Generic;
using PricingABasket.Items;

namespace PricingABasket.items
{
    public class ItemFactory : IItemFactory
    {
        private readonly Dictionary<string, IItem> _itemsMap;

        public ItemFactory()
        {
            _itemsMap = PopulateItemsMap();
        }

        private static Dictionary<string, IItem> PopulateItemsMap()
        {
            var map = new Dictionary<string, IItem>(StringComparer.InvariantCultureIgnoreCase);
            map["Apples"] = new Apples();
            map["Soup"] = new Soup();
            map["Bread"] = new Bread();
            map["Milk"] = new Milk();
            return map;
        } 

        public IItem CreateItem(string description)
        {
            if (_itemsMap.ContainsKey(description))
            {
                return _itemsMap[description];
            }
            throw new NotSupportedException("Invalid item description [" + description + "]");
        }
    }
}
