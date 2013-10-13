namespace PricingABasket.items
{
    class Soup : IItem
    {
        public string Description
        {
            get { return "Soup"; }
        }

        public decimal Price
        {
            get { return 0.65m; }
        }

        public UnitType Unit
        {
            get { return UnitType.Tin; }
        }
    }
}
