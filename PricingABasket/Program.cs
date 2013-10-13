using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PricingABasket.Items;
using PricingABasket.Offers;
using PricingABasket.Pricing;
using PricingABasket.items;

namespace PricingABasket
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var itemFactory = new ItemFactory();

                var items = ParseItems(itemFactory, args);
                var offers = GetAllOffers();
                var calculator = new PriceCalculator(items, offers);
                var result = calculator.CalculateTotal();

                Console.WriteLine("Subtotal: £" + result.SubTotal);

                if (result.ApplicableOffers.Any())
                {
                    foreach (var offer in result.ApplicableOffers)
                    {
                        Console.WriteLine(offer.Description + ": " + offer.Saving);
                    }
                }
                else
                {
                    Console.WriteLine("(No offers available)");
                }

                Console.WriteLine("Total: £" + result.Total);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }

        private static IEnumerable<IItem> ParseItems(IItemFactory itemFactory, IEnumerable<string> args)
        {
            var items = new List<IItem>();
            foreach (var description in args)
            {
                var item = itemFactory.CreateItem(description);
                items.Add(item);
            }
            return items;
        }

        private static IEnumerable<IOffer> GetAllOffers()
        {
            return new List<IOffer>();
        }
    }
}
