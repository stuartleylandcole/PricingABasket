using System;
using System.Collections.Generic;
using System.Linq;
using PricingABasket.Calculator;
using PricingABasket.Items;
using PricingABasket.Items.Offers;

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
                Console.WriteLine("Items:");
                foreach (var item in items)
                {
                    Console.WriteLine(item.Description + " - £" + item.Price.ToString("F") + " per " + item.Unit);
                }

                Console.WriteLine();

                var offers = GetAllOffers();
                Console.WriteLine("Offers");
                foreach (var offer in offers)
                {
                    Console.WriteLine(offer.Description);
                }

                var calculator = new PriceCalculator(items, offers);
                var result = calculator.Calculate();

                Console.WriteLine();
                Console.WriteLine("Subtotal: £" + result.SubTotal.ToString("F"));

                if (result.ApplicableOffers.Any())
                {
                    foreach (var offer in result.ApplicableOffers)
                    {
                        Console.WriteLine(offer.Description + ": -£" + offer.Saving.ToString("F"));
                    }
                }
                else
                {
                    Console.WriteLine("(No offers available)");
                }

                Console.WriteLine("Total: £" + result.Total.ToString("F"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }

        private static IList<IItem> ParseItems(IItemFactory itemFactory, IEnumerable<string> args)
        {
            var items = new List<IItem>();
            foreach (var description in args)
            {
                var item = itemFactory.CreateItem(description);
                items.Add(item);
            }
            return items;
        }

        private static IList<IOffer> GetAllOffers()
        {
            return new List<IOffer>
                {
                    new AppleTenPercentDiscount(),
                    new HalfPriceLoafWithTwoTinsOfSoup()
                };
        }
    }
}
