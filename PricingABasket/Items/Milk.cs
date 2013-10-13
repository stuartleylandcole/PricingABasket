namespace PricingABasket.Items
{
    class Milk : IItem
    {
        public string Description
        {
            get { return "Milk"; }
        }

        public decimal Price
        {
            get { return 1.30m; }
        }

        public UnitType Unit
        {
            get { return UnitType.Bottle; }
        }
    }
}
