namespace PricingABasket.items
{
    class Bread : IItem
    {
        public string Description
        {
            get { return "Bread"; }
        }

        public decimal Price
        {
            get { return 0.80m; }
        }

        public UnitType Unit
        {
            get { return UnitType.Loaf; }
        }
    }
}
